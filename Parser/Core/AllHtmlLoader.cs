using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Parser.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    class AllHtmlLoader
    {
        List<string> items = new List<string>();
        public delegate void Return(IArticle article);
        public event Return NewData;
        public delegate void bools(bool f1);
        public event bools OnCompleted;
        public DataBase dataBase = new DataBase();
        HttpClient client = new HttpClient();
        private int i = 0;

        public void GoLoad(string request, Settings settings)
        {
            try
            {
                List<Task> tasks = new List<Task>();
                int count = settings.Sites.Length;
                settings.Sites = (from x in settings.Sites
                                  where !x.Contains("katus.eu")
                                  select x).ToArray();

                if (count != settings.Sites.Length)
                {
                    tasks.Add(new Task(() => katus(request)));
                }
                foreach (string url in settings.Sites)
                {
                    tasks.Add(new Task(() => GoParse(url, request, settings)));
                }
                foreach(var x in tasks)
                {
                    x.Start();
                    x.Wait();
                }
                Task.WaitAll(tasks.ToArray());
                OnCompleted?.Invoke(true);
            }
            catch
            {
                OnCompleted?.Invoke(false);
            }
        }

        private void katus(string request)
        {
            request = request.Replace(" ", "%20");
            KatusHtmlLoader<KatusArticle> Katus = new KatusHtmlLoader<KatusArticle>(new KatusSettings(), request);
            Katus.OnNewData += OnNewData;
            Katus.Worker();
        }
        private object aa = new object();
        private void GoParse(string url, string request, Settings settings)
        {
            List<string> sites = new List<string>();
            sites.Add(url);
            List<string> already = new List<string>();
            /*входная точка. Далее отправляем в воркер этот урл. Воркер возращает массив ссылок, мы запускаем воркера по этим ссылкам опять
            у нас есть тут массив уже пройденных ссылок. и массив непройденных. Тут должны следить за вложенностью*/
            int vlozhennost = 0;
            while (sites.Count != 0)
            {
                if (!already.Contains(sites[0]))
                {
                    try
                    {
                        Console.WriteLine(sites[0]);
                        System.Threading.Thread.Sleep(settings.Interval);
                        List<string> arr = Worker(sites[0], request, settings).Result;
                        sites.AddRange(arr);
                        Console.WriteLine(sites[0]);
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка - " + sites[0]);
                    }
                    already.Add(sites[0]);
                    sites.RemoveAt(0);
                }
                else
                {
                    sites.RemoveAt(0);
                }
            }
        }

        private async Task<List<string>> Parse(IHtmlDocument document, string request, string url, Settings settings)
        {
            //парсит документ на статьи. Должен по сути возвращать void, а отправлять статьи через эвенты
            
            List<string> sites = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.Attributes["href"].Value != null && (item.Attributes["href"].Value.Contains(url) || item.Attributes["href"].Value[0] == '/'));
            string[] site = (from x in items
                                select x.Attributes["href"].Value).ToArray();
            if (url.Last() == '/')
                url = url.Remove(url.Length - 1);
            for (int i = 0; i < site.Length; i++)
                if (site[i][0] == '/')
                {
                    site[i] = url + site[i];
                }
            sites.AddRange(site);
            if (settings.Chastich)
            {
                string[] arr = request.Split(' ');
                foreach (string x in arr)
                {
                    if (document.Source.Text.Contains(x))
                    {
                        DownloadPage(url, request);
                        AddTitle(document, request, url);
                    }
                }
            }
            else if (document.Source.Text != null && document.Source.Text.Contains(request))
            {
                DownloadPage(url, request);
                AddTitle(document, request, url);
            }
            return sites;
        }
        private void DownloadPage(string url, string requests)
        {

            KatusSettings settings = new KatusSettings();
            //url = settings.BaseUrl + url;
            string data = " ";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            Cookie cookie = new Cookie
            {
                Name = "Name",
                Value = "Value"
            };
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Uri(url), cookie);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }
                data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
            }
            string s = DateTime.Now.ToString("dd.MM.yyyy");
            string directory = @"history/" + s + "/" + requests.Replace("/", "-").Replace(" ", "_") + "/";
            string writePath = directory + i.ToString() + ".html";
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            while (File.Exists(writePath))
            {
                i++;
                writePath = directory + i.ToString() + ".html";
            }
            StreamWriter sw = new StreamWriter(writePath, true);
            try
            {
                sw.WriteLine(data);
                i++;
            }
            catch
            {

            }
            sw.Close();
        }

        private void AddTitle(IHtmlDocument document, string request, string url)
        {
            DefaultArticle article = new DefaultArticle();
            article.Title = document.Title;
            //article.Text = "..." + document.Source.Text.Substring(document.Source.Text.IndexOf(request) - 15 < 0 ? 0 : document.Source.Text.IndexOf(request) - 15,
            //        document.Source.Text.IndexOf(request) + 15 > document.Source.Text.Length ? document.Source.Text.Length : document.Source.Text.IndexOf(request) + 15) + "...";
            article.Text = "Было найдено совпадение - " + request;//"..." + document.Source.Text.Substring(document.Source.Text.IndexOf(request) - 15, document.Source.Text.IndexOf(request) + 15) + "...";
            article.Date = DateTime.Now.ToString("dd.MM.yyyy");
            article.Link = url;
            dataBase.AddArticles(article);
            NewData?.Invoke(article);
        }
        public async Task<List<string>> Worker(string url, string request, Settings settings)
        {
            var source = await GetSource(url);
            var domParser = new HtmlParser();

            var document = await domParser.ParseDocumentAsync(source);

            return Parse(document, request, url, settings).Result;
        }

        public async Task<string> GetSource(string url)
        {
            var response = await client.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }




        private void OnNewData(object arg1, IArticle arg2)
        {
            dataBase.AddArticles(arg2);
            NewData?.Invoke(arg2);
        }
    }
}
