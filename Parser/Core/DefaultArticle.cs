using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    class DefaultArticle : IArticle
    {
        /// <summary>
        /// Заголовок статьи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Текст статьи
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Дата статьи
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Ссылка на статью
        /// </summary>
        public string Link { get; set; }
    }
}
