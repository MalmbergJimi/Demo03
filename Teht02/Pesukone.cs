﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Pesukone
    {
        public bool IsOn { get; set; }
        public int WaterTemp { get; set; }
        public string CColor { get; set; }
        public string Program { get; set; }

        public void OpenHatch()
        {
            Console.WriteLine("Luukku on nyt auki");
        }

        public void CloseHatch()
        {
            Console.WriteLine("Luukku on nyt kiinni");
        }

        public void Wash()
        {
            Console.WriteLine("Wurruururururururu... Pesu on valmis");
        }
    }
}
