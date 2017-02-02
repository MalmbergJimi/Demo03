using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04_1
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }


        public void PrintData()
        {
            Console.WriteLine("Vehicle's name: - " + Name);
            Console.WriteLine("Vehicle's speed: - " + Speed);
            Console.WriteLine("Number of tyres: - " + Tyres);
        }
    }
}
