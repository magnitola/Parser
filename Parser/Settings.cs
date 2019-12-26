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
        public int Interval { get; set; }
        public string Nesting { get; set; }
        public string[] Sites { get; set; }
        public bool Chastich { get; set; }
        public Settings(int Interval, string Nesting, string[] Sites, bool Chastich)
        {
            this.Interval = Interval;
            this.Nesting = Nesting;
            this.Sites = Sites;
            this.Chastich = Chastich;
        }
    }
}
