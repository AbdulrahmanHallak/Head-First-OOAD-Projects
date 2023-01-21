using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    public enum GuitarType
    {
        Acoustic,
        Electric
    }
    public enum Builder
    {
        Fender, Martin, Gibson, Collings, Olson, Ryan, PRS, ANY

    }
    public enum Wood
    {
        INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, Mahogany, Maple, Cocobolo, Cedar, ADERONDACK, Alder, Sitka
    }


    internal class GuitarSpec
    {
        public GuitarType Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; } 
        public string Model { get; set; }
        public Builder Builder { get; set; }

        public GuitarSpec(string model , Builder builder , GuitarType type , Wood backWood , Wood topWood)
        {

            this.Model = model;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.Builder = builder;
            this.Type = type;
            this.Builder = builder;
        }
    }
}
