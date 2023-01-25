using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoor
{
    internal class Remote
    {
        private static System.Timers.Timer timer = new System.Timers.Timer(3000);
        private Door _door;
        public Remote(Door door)
        {
            this._door = door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button");
            if (_door.isOpen())
            {
                _door.Close();
            }
            else { _door.Open(); timer.Elapsed += Autoclose; timer.Enabled = true; }
        }

        private void Autoclose(object? sender, ElapsedEventArgs e)
        {
            if(_door.isOpen()) { _door.Close(); timer.Stop(); }
        }
    }
}
