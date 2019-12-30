using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    [Serializable]
    public class Settings
    {
        /// <summary>
        /// Интервал поиска
        /// </summary>
        public int Interval { get; set; }
        /// <summary>
        /// Вложенность
        /// </summary>
        public string Nesting { get; set; }
        /// <summary>
        /// Список сайтов
        /// </summary>
        public string[] Sites { get; set; }
        /// <summary>
        /// Частичное совпадение
        /// </summary>
        public bool Chastich { get; set; }
        /// <summary>
        /// Ключевые слова
        /// </summary>
        public string [] Tags { get; set; }
        public Settings(int Interval, string Nesting, string[] Sites, bool Chastich, string[] Tags)
        {
            this.Interval = Interval;
            this.Nesting = Nesting;
            this.Sites = Sites;
            this.Chastich = Chastich;
            this.Tags = Tags;
        }
    }
}
