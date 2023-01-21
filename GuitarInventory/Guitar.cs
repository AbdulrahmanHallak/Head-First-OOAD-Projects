using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; set; }
     
        public Guitar(string serialNumber, string model, Builder builder,
            double price, GuitarType type, Wood backWood, Wood topWood)
        {
            var guitarSpec = new GuitarSpec(model, builder, type, backWood, topWood);
            Spec = guitarSpec;
            SerialNumber = serialNumber;
            Price = price;
            
        }
    }
}
