using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance from Car class
            Car car =new Car();
            car.PrintData();             //Tulostetaan
            car.Model = "Peugeot 206";
            car.Color = "Red";
            car.Engine = 1.6;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 3;
            car.Accelerate();
            car.PrintData();            //Tulostetaan
            car.Brake(7);
            Car.SomeProperty = 56;
            car.PrintData();             //Tulostetaan

            // Create another car object

            string model = "Speedster";
            Car nascar = new Car(model);
            nascar.PrintData(); //Tulostetaan
            nascar.Color = "Black";
            Console.WriteLine("Color is " + nascar.Color);


        }
    }
}
