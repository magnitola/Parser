using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    interface IParserSettings
    {
        /// <summary>
        /// Главный URL
        /// </summary>
        string BaseUrl { get; set; }
        /// <summary>
        /// По какому адресу нужно провести поиск
        /// </summary>
        string Prefix { get; set; }
        //int StartPoint { get; set; }
        //int EndPoint { get; set; }
    }
}
