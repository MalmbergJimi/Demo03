using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater kiuas = new Heater();
            kiuas.IsOn = true;
            kiuas.Temperature = 90;
            kiuas.Humidity = 95.5;
            
            kiuas.ThrowWater();
            Console.WriteLine("Temperature is " + kiuas.Temperature);
            Console.WriteLine("Humidity is " + kiuas.Humidity);




        }
    }
}
