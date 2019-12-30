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

        /// <summary>
        /// Получить список заголовков статьи
        /// </summary>
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
        /// <summary>
        /// Получить статью по индексу
        /// </summary>
        /// <param name="number">Индекс статьи</param>
        /// <returns></returns>
        public IArticle GetArticle(int number)
        {
            try
            {
                return articles[number];
            }
            catch
            {
                return new KatusArticle();
            }
        }
        /// <summary>
        /// Получить кол-во статей
        /// </summary>
        /// <returns></returns>
        public int CountArticles()
        {
            return articles.Count;
        }
    }
}
