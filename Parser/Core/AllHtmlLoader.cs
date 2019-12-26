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

        public void GoLoad(string[] request, Settings settings)
        {
            try
            {
                List<Task> tasks = new List<Task>();
                List<DefaultParse> defaultParses = new List<DefaultParse>();
                int count = settings.Sites.Length;
                settings.Sites = (from x in settings.Sites
                                  where !x.Contains("katus.eu")
                                  select x).ToArray();

                if (count != settings.Sites.Length)
                {
                    tasks.Add(new Task(() => katus(request)));
                }
                foreach (string x in settings.Sites)
                {
                    DefaultParse parser = new DefaultParse();
                    parser.New += OnNewData;
                    tasks.Add(new Task(() => parser.GoParse(x, request, settings)));
                    defaultParses.Add(parser);
                }
                foreach(var x in tasks)
                {
                    x.Start();
                }
                Task.WaitAll(tasks.ToArray());
                OnCompleted?.Invoke(true);
            }
            catch
            {
                OnCompleted?.Invoke(false);
            }
        }

        private void katus(string[] req)
        {
            foreach (var request in req)
            {
                KatusHtmlLoader<KatusArticle> Katus = new KatusHtmlLoader<KatusArticle>(new KatusSettings(), request.Replace(" ", "%20"));
                Katus.OnNewData += OnNewData;
                Katus.Worker();
            }
        }

        private void OnNewData(object arg1, IArticle arg2)
        {
            dataBase.AddArticles(arg2);
            NewData?.Invoke(arg2);
        }
    }
}
