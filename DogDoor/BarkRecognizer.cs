﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor
{
    internal class BarkRecognizer
    {
        private Door _door;
        public string OwnersDogBark { get; set; }
        public BarkRecognizer(Door door)
        {
            _door= door;
        }
        public void Recognize(Bark bark) 
        {
            Console.WriteLine($"Bark Recognizer heard a {bark.GetBarkSound()} ");
            foreach(var allowedBark in _door.GetAllowedBarks())
            {
                if (allowedBark.equals(bark))
                {
                    _door.Open();
                    break;
                }
            }
            
        }
        public bool IsOwnersDog(string bark) 
        {
            return bark.ToLower().Equals(OwnersDogBark.ToLower());
        }
    }
}
