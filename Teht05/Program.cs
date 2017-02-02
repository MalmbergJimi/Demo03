using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Opiskelija heikko = new Opiskelija();
            heikko.Nimi = "Heikko Hyyppä";
            heikko.Tunnus = "K1234";
            heikko.Ojaksot = 5;
            heikko.Opisteet = 27;
            heikko.PrintData();
            heikko.EiOsallistu();

            Console.WriteLine(); // ENTER

            Opiskelija tarmo = new Opiskelija();
            tarmo.Nimi = "Tarmo Tarmokas";
            tarmo.Tunnus = "K4321";
            tarmo.Ojaksot = 9;
            tarmo.Opisteet = 45;
            tarmo.PrintData();
            tarmo.Osallistu();

            Console.WriteLine(); // ENTER

            Opiskelija keiju = new Opiskelija();
            keiju.Nimi = "Keiju Hammas";
            keiju.Tunnus = "K1010";
            keiju.Ojaksot = 1;
            keiju.Opisteet = 10;
            keiju.PrintData();
            keiju.Palauta();

            Console.WriteLine(); // ENTER
        }
    }
}
