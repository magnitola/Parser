using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    public class DefaultParse
    {
        internal delegate void Return(object arg, IArticle article);
        internal event Return New;

        private int i;
        /// <summary>
        /// Точка входа в универсальный парсер
        /// </summary>
        /// <param name="url">Ссылка на сайт</param>
        /// <param name="request">Ключевые слова</param>
        /// <param name="settings">Настройки</param>
        public void GoParse(string url, string[] request, Settings settings)
        {
            List<string> sites = new List<string>();
            sites.Add(url);
            List<string> already = new List<string>();
            /*входная точка. Далее отправляем в воркер этот урл. Воркер возращает массив ссылок, мы запускаем воркера по этим ссылкам опять
            у нас есть тут массив уже пройденных ссылок. и массив непройденных. Тут должны следить за вложенностью*/
            while (sites.Count != 0)
            {
                if (!already.Contains(sites[0]))
                {
                    try
                    {
                        System.Threading.Thread.Sleep(settings.Interval * 1000);
                        List<string> arr = Worker(sites[0], request, settings).Result;
                        sites.AddRange(arr);
                        //Console.WriteLine(sites[0]);
                    }
                    catch
                    {
                        //Console.WriteLine("Ошибка - " + sites[0]);
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
        /// <summary>
        /// Возвращает кол-во обратных слешей из ссылки
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private int Count(string url)
        {
            int counturl = 0;
            foreach (char x in url)
            {
                if (x == '/')
                    counturl++;
            }
            return counturl;
        }
        /// <summary>
        /// Основной метод парсера
        /// </summary>
        /// <param name="document">Html документ страницы</param>
        /// <param name="req">Запросы</param>
        /// <param name="url">Ссылка на страницу</param>
        /// <param name="settings">Настройки</param>
        /// <returns></returns>
        private async Task<List<string>> Parse(IHtmlDocument document, string[] req, string url, Settings settings)
        {
            //парсит документ на статьи. Должен по сути возвращать void, а отправлять статьи через эвенты
            int vlozhennost;
            if (settings.Nesting == "all")
                vlozhennost = 99999999;
            else
                vlozhennost = int.Parse(settings.Nesting);
            if (url.Last() == '/')
                url = url.Remove(url.Length - 1);
            int counturl = Count(url);
            List<string> sites = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.Attributes["href"].Value != null && (item.Attributes["href"].Value.Contains(url) || item.Attributes["href"].Value[0] == '/') && (Count(item.Attributes["href"].Value) - counturl + 1) < vlozhennost);
            string[] site = (from x in items
                             select x.Attributes["href"].Value).ToArray();
            for (int i = 0; i < site.Length; i++)
                if (site[i][0] == '/')
                {
                    site[i] = url + site[i];
                }
            sites.AddRange(site);
            foreach (var request in req)
            {
                if (settings.Chastich)
                {
                    string[] arr = request.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
            }
            return sites;
        }
        /// <summary>
        /// Скачать страницу
        /// </summary>
        /// <param name="url">Ссылка</param>
        /// <param name="requests">Ключевое слово</param>
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

        /// <summary>
        /// Отправить найденную статью
        /// </summary>
        /// <param name="document">Html документ страницы</param>
        /// <param name="request">Ключевое слово</param>
        /// <param name="url">Ссылка на страницу</param>
        private void AddTitle(IHtmlDocument document, string request, string url)
        {
            DefaultArticle article = new DefaultArticle();
            article.Title = document.Title;
            //article.Text = "..." + document.Source.Text.Substring(document.Source.Text.IndexOf(request) - 15 < 0 ? 0 : document.Source.Text.IndexOf(request) - 15,
            //        document.Source.Text.IndexOf(request) + 15 > document.Source.Text.Length ? document.Source.Text.Length : document.Source.Text.IndexOf(request) + 15) + "...";
            article.Text = "Было найдено совпадение - " + request;//"..." + document.Source.Text.Substring(document.Source.Text.IndexOf(request) - 15, document.Source.Text.IndexOf(request) + 15) + "...";
            article.Date = DateTime.Now.ToString("dd.MM.yyyy");
            article.Link = url;
            New?.Invoke(this, article);
        }
        /// <summary>
        /// Обработчик страницы
        /// </summary>
        /// <param name="url">Ссылка на страницу</param>
        /// <param name="request">Ключевые слова</param>
        /// <param name="settings">Настройки</param>
        /// <returns></returns>
        public async Task<List<string>> Worker(string url, string[] request, Settings settings)
        {
            var source = await GetSource(url);
            var domParser = new HtmlParser();

            var document = await domParser.ParseDocumentAsync(source);

            return Parse(document, request, url, settings).Result;
        }
        /// <summary>
        /// Получить Html страницу
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<string> GetSource(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
