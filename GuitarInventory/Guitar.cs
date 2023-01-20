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
        public string Model { get; set; }
        public Builder Builder { get; set; }
        public double Price { get; set; }
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }

        public Guitar(string serialNumber, string model, Builder builder,
            double price, Type type, Wood backWood, Wood topWood)
        {
            SerialNumber = serialNumber;
            Model = model;
            Builder = builder;
            Price = price;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }
    }
}
