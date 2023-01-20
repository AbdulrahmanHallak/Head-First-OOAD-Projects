using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Appendix2
{
    internal class Jet : AirPlane
    {
        private static int MULTIPLYER = 2;
        private int _speed;
        public int Speed { get => _speed;   set => _speed = value * MULTIPLYER;  }
        public Jet()
        {
            Console.WriteLine("this is jet ctor");
        }

        public void print() { Console.WriteLine("hello"); }
    }
}
