using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB2
{
    class Movie
    {
        public string name { get; set; }
        public string link { get; set; }
        public string year { get; set; }
        public string rating { get; set; }//float çevirilebilir ?
        public string desc { get; set; }

        public override string ToString()
        {
            return (this.name+" "+this.year) ;
            
        }
    }
}
