using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpSenses;
using Dear;
using Dear.KeyboardControl;

namespace next.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {            
            ICamera cam = Camera.Create();
            var win = new Dear.MrWindows();
            Command command = new Command(win, cam);
            cam.Gestures.SlideRight += (s, a) => command.next();
            cam.Gestures.SlideLeft += (s, a) => command.previous();
            cam.Start();
            Console.ReadLine();
        }

    }
}
