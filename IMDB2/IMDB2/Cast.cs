using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB2
{
    class Cast
    {
        public string name { get; set; }
        public string link { get; set; }
        public string bio { get; set; }
        public string born { get; set; }
        public override string ToString()
        {
            return this.name;
        }
    }
}
