using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor
{
    internal class BarkRecognizer
    {
        private Door _door;
        public BarkRecognizer(Door door)
        {
            _door= door;
        }
        public void Recognize(string bark) 
        {
            Console.WriteLine($"Bark Recognizer heard a {bark} ");
            _door.Open();
        }

    }
}
