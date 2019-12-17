using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    interface IArticle
    {
        string Title { get; set; }
        string Text { get; set; }
        string Date { get; set; }
        string Link { get; set; }
    }
}
