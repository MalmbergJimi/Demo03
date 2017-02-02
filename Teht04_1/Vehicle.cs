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
            Console.WriteLine("Vehicle specs:");
            Console.WriteLine("Vehicle's name: - " + Name);
            Console.WriteLine("Vehicle's speed: - " + Speed);
            Console.WriteLine("Number of tyres: - " + Tyres);
        }

        public void ToString()
        {
            

        }

        public void Accelerate() //Kaasua + 10;
        {
            Speed += 10; 
        }

        public void Brake() // Jarrua - 5;
        {
            Speed -= 5; 
        }

        public void RemoveTyre()
        {
            Tyres -= 1;
        }
    }
}
