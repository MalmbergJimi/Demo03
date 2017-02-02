using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone(); // Luodaan pesukone
            pesukone.IsOn = true;
            pesukone.WaterTemp = 40;
            pesukone.CColor = "White";
            pesukone.Program = "Ekopesu";
                        
            pesukone.CloseHatch(); // Suljetaan luukku
            Console.WriteLine("Pesuveden lämpötila on " + pesukone.WaterTemp);
            Console.WriteLine("Pestävän pyykin väri on " + pesukone.CColor);
            Console.WriteLine("Pesuohjlema on " + pesukone.Program);
            pesukone.Wash();
            pesukone.OpenHatch();
            Console.WriteLine();

            string program = "Pikapesu"; // Vaihdetaan pesuohjelma
            Pesukone pesee = new Pesukone(program);
            Console.WriteLine("Pesuveden lämpötila on " + pesukone.WaterTemp);
            Console.WriteLine("Pestävän pyykin väri on " + pesukone.CColor);
            Console.WriteLine("Pesuohjlema on " + program);


        }
    }
}
