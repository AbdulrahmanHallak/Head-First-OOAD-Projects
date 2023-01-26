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
            else _door.Open();
        }

      
    }
}
