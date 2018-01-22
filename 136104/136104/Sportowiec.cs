using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136104
{
    abstract class  Sportowiec
    {
        protected string imie;
        protected char klub;
        public Sportowiec(string imie, char klub)
        {
            this.imie = imie;
            this.klub = klub;
            
        }
        abstract public string Zawody(int a);
    }
}
