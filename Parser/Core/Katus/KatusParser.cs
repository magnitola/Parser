using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;

namespace Parser.Core
{
    class KatusParser : IParser<KatusArticle>
    {
        public IEnumerable<KatusArticle> Parse(IHtmlDocument document)
        {
            var t1 = Task.Run(() => GetText(document));
            var t2 = Task.Run(() => GetTitle(document));
            var t3 = Task.Run(() => GetDate(document));
            Task.WaitAll(t1, t2, t3);
            var text = t1.Result;
            var title = t2.Result;
            var date = t3.Result;
            for (int i = 0; i < text.Length; i++)
            {
                title[i].Text = text[i];
                title[i].Date = date[i];
                yield return title[i];
            }
        }

        private string[] GetDate(IHtmlDocument document)
        {
            List<string> katusArticles = new List<string>();
            var items = document.QuerySelectorAll("dd").Where(item => item.ClassName != null && item.ClassName.Contains("result-created"));
            foreach (var item in items)
            {
                KatusArticle article = new KatusArticle();
                string temp = item.TextContent.Replace("\n", "").Replace("\t", "").Replace("Created on ", "").Replace(" ", "").Replace("January", "01").Replace("February", "02").Replace(
                    "March", "03").Replace("April", "04").Replace("May", "05").Replace("June", "06").Replace("July", "07").Replace("August", "08").Replace("September", "09").Replace(
                    "October", "10").Replace("November", "11").Replace("December", "12");
                string st = temp[6].ToString() + temp[7].ToString() + temp[2].ToString() + temp[3].ToString() + temp[0].ToString() + temp[1].ToString();
                katusArticles.Add(st);
            }
            return katusArticles.ToArray();
        }
        private string[] GetText(IHtmlDocument document)
        {
            List<string> katusArticles = new List<string>();
            var items = document.QuerySelectorAll("dd").Where(item => item.ClassName != null && item.ClassName.Contains("result-text"));
            foreach (var item in items)
            {
                KatusArticle article = new KatusArticle();
                string temp = item.TextContent.Replace("\n", "").Replace("\t", "").Replace("<span class=\"highlight\">", "").Replace("</span>", "");
                katusArticles.Add(temp);
            }
            return katusArticles.ToArray();
        }
        private KatusArticle[] GetTitle(IHtmlDocument document)
        {
            List<KatusArticle> katusArticles = new List<KatusArticle>();
            var items = document.QuerySelectorAll("dt").Where(item => item.ClassName != null && item.ClassName.Contains("result-title"));
            foreach (var item in items)
            {
                KatusArticle article = new KatusArticle();
                string temp = item.TextContent.Replace("\n", "").Replace("\t", "").Replace("<span class=\"highlight\">", "").Replace("</span>", "");
                temp = temp.Remove(0, temp.IndexOf('.') + 2);
                article.Title = temp;
                article.Link = item.QuerySelectorAll("a").First().Attributes["href"].Value;
                //list.Add(temp + " - " + item.QuerySelectorAll("a").First().Attributes["href"].Value);
                katusArticles.Add(article);
            }
            return katusArticles.ToArray();
        }
    }
}
