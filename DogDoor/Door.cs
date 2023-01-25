using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor
{
    internal class Door
    {
        private bool _open;
        public Door()
        {
            this._open = false;
        }
        public void Open()
        {
            Console.WriteLine("The dog door opens");
            this._open = true;
        }
        public void Close()
        {
            Console.WriteLine("The dog door closes");
            this._open = false;
        }
        public bool isOpen()
        {
            return this._open;
        }
    }
}
