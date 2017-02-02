using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mazda = new Vehicle();
            mazda.Name = "Mazda 626";
            mazda.Speed = 145;
            mazda.Tyres = 4;

            mazda.PrintData();

            Console.WriteLine(); // ENTER

            Vehicle audi = new Vehicle();
            audi.Name = "Audi A4";
            audi.Speed = 192;
            audi.Tyres = 4;
            audi.PrintData();
            Console.WriteLine(); // ENTER

            audi.Accelerate();
            audi.PrintData();
            Console.WriteLine(); // ENTER

            audi.RemoveTyre();
            Console.WriteLine(audi.Name + " You have only " + audi.Tyres + " tyres left!");
            Console.WriteLine("And your speed is " + audi.Speed);
            audi.Brake();
            Console.WriteLine("Now your speed is " + audi.Speed);



            Console.WriteLine(); // ENTER
        }
    } 
    }

