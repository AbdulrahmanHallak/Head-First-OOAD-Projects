using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoor
{
    internal class Door
    {
        private static System.Timers.Timer timer = new System.Timers.Timer(3000);
        private bool _open;
        public Door()
        {
            this._open = false;
        }
        public void Open()
        {
            Console.WriteLine("The dog door opens");
            this._open = true;
            timer.Elapsed += Autoclose; timer.Enabled = true;
        }
        public void Close()
        {
            Console.WriteLine("The dog door closes");
            this._open = false;
            timer.Stop();
        }
        public bool isOpen()
        {
            return this._open;
        }
        private void Autoclose(object? sender, ElapsedEventArgs e)
        {
            if (isOpen()) Close();  
        }
    }
}
