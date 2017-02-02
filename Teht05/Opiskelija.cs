using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public string Tunnus { get; set; }
        public int Ojaksot { get; set; }
        public int Opisteet { get; set; }

        public void Palauta()
        {
            Opisteet += 3;
            Console.WriteLine("Hienoa palautit rästitehtävät, nyt sinulla on opintopisteitä " + Opisteet);
        }

        public void Osallistu()
        {
            Ojaksot += 1;
            Console.WriteLine("Osallistuit uudelle opintojaksolle. Nyt olet " + Ojaksot + " opintojaksolla.");
        }

        public void EiOsallistu()
        {
            Ojaksot -= 1;
            Console.WriteLine("Jätit yhden opintojakson pois. Sinulla on enää " + Ojaksot + " opintojaksoa.");
        }

        public void PrintData()
        {
            Console.WriteLine(Nimi);
            Console.WriteLine(Tunnus);
            Console.WriteLine("Opintojaksoja: " + Ojaksot);
            Console.WriteLine("Opintopisteitä: " + Opisteet);

        }
    }
}
