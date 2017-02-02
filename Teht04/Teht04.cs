using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
    {
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle teevee = new Vehicle();
            teevee.IsOn = true;
            teevee.Channel = 40;
            teevee.Volume = 15;
            teevee.Recording = false;
            teevee.Mute = false;
            teevee.ScreenMode = "GAMES";

            
        }
    }
}
