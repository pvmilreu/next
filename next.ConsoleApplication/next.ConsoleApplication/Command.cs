using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dear;
using Dear.KeyboardControl;
using SharpSenses;
namespace next.ConsoleApplication
{
    class Command
    {
        protected MrWindows win;
        protected ICamera cam;
        public Command(MrWindows win, ICamera cam)
        {
            this.win = win;
            this.cam = cam;
        }

        public void next()
        {
            win.Keyboard.Type(VirtualKey.Right);
        }

        public void previous()
        {
            win.Keyboard.Type(VirtualKey.Left);
        }
    }
}
