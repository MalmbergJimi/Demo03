using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // Properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty {get;set;}

        // Default constructor
        public Car()
        {

        }

        // Constructor...
        public Car(string model)
        {
            Model = model;
        }


        // Method to give more speed
        public void Accelerate()
        { 
            Speed += 10; // Speed = Speed + 10;
        }

        // Method to slow down
        public void Brake(int value)
        {
            Speed -= value; // Speed = Speed - 10;
        }

        // Method to display car date
        public void PrintData()
        {
            Console.WriteLine("Car properties:");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- dices : " + FuzzyDices);
            Console.WriteLine("- door count :" + DoorCount);
            Console.WriteLine("- some static property : " + SomeProperty);
            
        }
            
        // Destructor
        ~Car()
        {
            Console.WriteLine("Car object is destroyed!");
        }
            
     } //class
} //namespace
