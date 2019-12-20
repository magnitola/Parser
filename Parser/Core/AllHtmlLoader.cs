using Parser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async void GoLoad(string request)
        {
            try
            {
                request = request.Replace(" ", "%20");
                KatusHtmlLoader<KatusArticle> Katus = new KatusHtmlLoader<KatusArticle>(new KatusSettings(), request);
                Katus.OnNewData += OnNewData;
                await Katus.Worker();
                OnCompleted?.Invoke(true);
            }
            catch(Exception e)
            {
                OnCompleted?.Invoke(false);
            }
            
        }

        private void OnNewData(object arg1, IArticle arg2)
        {
            dataBase.AddArticles(arg2);
            NewData?.Invoke(arg2);
        }
    }
}
