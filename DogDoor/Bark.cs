using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor
{
    internal class Bark
    {
        private string _barkSound;
        public Bark(string barkSound)
        {
            _barkSound = barkSound;
        }

        public bool equals(Bark bark)
        {
            if(bark.GetBarkSound().ToLower().Equals(_barkSound.ToLower()))
                return true;
            return false;
        }
        public string GetBarkSound()
        {
            return _barkSound;
        }
    }
}
