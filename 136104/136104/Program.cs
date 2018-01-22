using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace _136104
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportowiec> sport = new List<Sportowiec>();
            sport.Add(new Biegacz("Waldemar",'W',12));
            sport.Add(new Biegacz("Tomasz", 'K', 19));
            sport.Add(new Biegacz("Adam", 'Z', 11));
            sport.Add(new Biegacz("Kamil", 'P', 14));

            foreach (Biegacz i in sport)
            {
                Console.WriteLine(i);
            }

            Zawodnik zaw1 = new Zawodnik();
            Console.WriteLine(zaw1.Miejsce("Olsztyn"));
            zaw1.UstawCzas(12);
            Console.WriteLine(zaw1.Medal());

            ////////////////////////////////////////////////////////////


            static Zawody zawod = new Zawody(5);

            
            try
            {
                Console.WriteLine("Podaj liczbe:");
                int liczba = Convert.ToInt32(Console.ReadLine());         
                Zawodnik zaw2 = new Zawodnik();
                zaw2.UstawCzas(liczba);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ArrayList Arlista = new ArrayList();
            Arlista.Add("Witaj");
            Arlista.Add(23);
            Arlista.Add(3.5);
            Arlista.Add(5.203);
            Arlista.Add('p');
            Arlista.Add(true);


                
                foreach (var i in Arlista)
                {
                    Console.WriteLine(i);
                }

                char[] np = { 's', 'f', 'm', 'r', 't'};
                LinkedList<char> LinkedLi = new LinkedList<char>(np);
                //LinkedList.AddAfter(m, 'w');
                

                

            

            Console.ReadLine();
        }
    }
}
