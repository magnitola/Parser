using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    class DefaultArticle : IArticle
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public string Link { get; set; }
    }
}
