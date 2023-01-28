﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class Guitar : Instrument
    {
        public Guitar(string serialNumber, double price, GuitarSpec spec) : base(serialNumber ,price , spec)
        {
            this.SerialNumber = serialNumber;
            this.Price = price; 
            this.Spec = spec;
        }
    }
}
