using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136104
{
    class Biegacz:Sportowiec
    {
        private int rekord;

        public Biegacz(string imie, char klub, int rekord)
            :base (imie,klub)
        {
            this.imie = imie;
            this.klub = klub;
            this.rekord = rekord;
        }


        public override string ToString()
        {
            return "Biegacz " + imie + ", klub " + klub + " rekord " + rekord;
        }

        override public string Zawody(int a)
        {
            return imie;
        }
    }
}
