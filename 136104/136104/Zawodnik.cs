using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136104
{
    class Zawodnik:IOlimpiada

    {

        private int czas;
        public int Miejsce(string arg)
        {
            return arg.Length;
        }

        public void UstawCzas(int czas)
        {
            this.czas = czas;
        }

        public bool Medal()
        {
            if(czas %2==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
