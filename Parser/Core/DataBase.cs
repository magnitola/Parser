using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    class DataBase
    {
        private List<IArticle> articles = new List<IArticle>();

        public void AddArticles(IArticle article) => articles.Add(article);

        public IEnumerable<string> Titles
        {
            get
            {
                foreach (var article in articles)
                {
                    yield return article.Title;
                }
            }
        }
        public IArticle GetArticle(int number)
        {
            return articles[number];
        }

    }
}
