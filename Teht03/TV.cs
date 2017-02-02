using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class TV
    {
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        public bool Recording { get; set; }
        public bool Mute { get; set; }
        public string ScreenMode { get; set; }

        // Default constructor 
        public TV()
        {

        }
        // Constructor Program
        public TV(string screenmode)
        {
            ScreenMode = screenmode;
        }

        public void TvOn()
        {
            Console.WriteLine("TV is now on!");
        }

        public void TvOff()
        {
            Console.WriteLine("TV is off.");
        }

        public void ChangeChanNext()
        {
            Channel += 1;
            Console.WriteLine("You changed the channel to channel " + Channel + ", nice choice!");
        }
        public void ChangeChanPrev()
        {
            Channel -= 1;
            Console.WriteLine("You put the previous channel " + Channel + " back, boooooriiiing...");
        }

        
    }
}
