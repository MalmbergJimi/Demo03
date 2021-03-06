﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Pesukone
    {
        public bool IsOn { get; set; }      // Päälle pois
        public int WaterTemp { get; set; }  // Veden lämpötila
        public string CColor { get; set; } // Pyykin väri
        public string Program { get; set; } // Pesuohjelma

        // Default constructor 
        public Pesukone()
        {

        }
        // Constructor Program
        public Pesukone(string program)
        {
            Program = program;
        }

        // Method to open hatch
        public void OpenHatch()
        {
            Console.WriteLine("Luukku on nyt auki");
        }

        // Method to close hatch
        public void CloseHatch()
        {
            Console.WriteLine("Luukku on nyt kiinni");
        }

        // Method to wash
        public void Wash()
        {
            Console.WriteLine("Wurruururururururu... Pesu on valmis");
        }
    }
}
