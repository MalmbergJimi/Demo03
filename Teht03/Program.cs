using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            TV teevee = new TV();
            teevee.IsOn = true;
            teevee.Channel = 40;
            teevee.Volume = 15;
            teevee.Recording = false;
            teevee.Mute = false;
            teevee.ScreenMode = "GAMES";

            teevee.TvOn();
            Console.WriteLine("You are watching channel number " + teevee.Channel);
            teevee.ChangeChanNext();
            Console.WriteLine("Volume is " + teevee.Volume);
            teevee.ChangeChanPrev();
            Console.WriteLine("So to the TV is on? " + teevee.IsOn);
            Console.WriteLine("Is is Recording? " + teevee.Recording);
            teevee.Volume = 10;
            Console.WriteLine("Volume is now " + teevee.Volume);
            Console.WriteLine("Your screenmode is " + teevee.ScreenMode);

            string screenmode = "MOVIES";
            Console.WriteLine("Your screenmode is now " + screenmode);
            teevee.Volume = 20;
            Console.WriteLine("Volume is now " + teevee.Volume);

            Console.WriteLine();
           teevee.TvOff();
        }
    }
}
