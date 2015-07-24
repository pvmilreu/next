using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpSenses;
using SharpSenses.Gestures;
namespace next.ConsoleApplication
{
    class Trigger
    {
        protected ICamera camera;
        protected Command command;
        
        public Trigger(ICamera camera, Command command)
        {
            this.camera = camera;
            this.command = command;
        }
        
        public Trigger registerNext()
        {
            var movement = Movement.Right(this.camera.RightHand, 18);
            movement.Completed += () => this.command.next();           
            movement.Activate();
            return this;
        }

        public Trigger registerPrevious()
        {
            var movement = Movement.Left(this.camera.RightHand, 18);
            movement.Completed += () => this.command.previous();
            movement.Activate();
            return this;
        }
        
        public Trigger registerOpen()
        {
            var movement = Movement.Up(this.camera.RightHand, 10);
            movement.Completed += () => this.command.open();
            movement.Activate();
            return this;
        }
    }
}
