using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class Mandolin : Instrument
    {
        public Mandolin(string serialNumber , double price , MandolinSpec spec) : base(serialNumber , price , spec)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = spec;
        }
    }
}
