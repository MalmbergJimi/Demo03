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
            Pesukone pesukone = new Pesukone();
            pesukone.IsOn = true;
            pesukone.WaterTemp = 40;
            pesukone.CColor = "White";
            pesukone.Program = "Ekopesu";
                        
            pesukone.CloseHatch();
            Console.WriteLine("Pesuveden lämpötila on " + pesukone.WaterTemp);
            Console.WriteLine("Pestävän pyykin väri on " + pesukone.CColor);
            Console.WriteLine("Pesuohjlema on " + pesukone.Program);
            pesukone.Wash();
            pesukone.OpenHatch();
            Console.WriteLine();

            string program = "Pikapesu";
            Pesukone pesee = new Pesukone(program);
            Console.WriteLine("Pesuveden lämpötila on " + pesukone.WaterTemp);
            Console.WriteLine("Pestävän pyykin väri on " + pesukone.CColor);
            Console.WriteLine("Pesuohjlema on " + program);


        }
    }
}
