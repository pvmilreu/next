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
            Trigger trigger = new Trigger(cam, command);
            trigger
                .registerNext()
                .registerPrevious()
                .registerOpen();
            cam.Start();
            Console.ReadLine();
        }
    }
}
