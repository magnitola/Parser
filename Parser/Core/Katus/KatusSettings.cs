using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    class KatusSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://katus.eu";
        public string Prefix { get; set; } = "component/search/?searchword={request}&searchphrase=all&limit=0";
        //public int StartPoint { get; set; }
        //public int EndPoint { get; set; }
    }
}
