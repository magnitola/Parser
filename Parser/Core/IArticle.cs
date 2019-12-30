using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    interface IArticle
    {
        /// <summary>
        /// Заголовок статьи
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// Текст статьи
        /// </summary>
        string Text { get; set; }
        /// <summary>
        /// Дата статьи
        /// </summary>
        string Date { get; set; }
        /// <summary>
        /// Ссылка на статью
        /// </summary>
        string Link { get; set; }
    }
}
