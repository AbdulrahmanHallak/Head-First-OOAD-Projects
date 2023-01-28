using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    public enum Type
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


    internal class GuitarSpec : InstrumentSpec
    {
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; } 
        public string Model { get; set; }
        public Builder Builder { get; set; }
        public int NumStrings { get; set; }

        public GuitarSpec(string model , Builder builder, Type type, Wood backWood, Wood topWood, int numStrings) : base(type ,backWood ,topWood , builder , model )

        {
            this.Model = model;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.Builder = builder;
            this.Type = type;
            NumStrings = numStrings;
        }
        public override bool Compare(InstrumentSpec searchInstrument)
        {
            if(!base.Compare(searchInstrument))
                return false;

            GuitarSpec spec = (GuitarSpec)searchInstrument;
            if(NumStrings != spec.NumStrings )
                return false;

            return true;
        }
    }
}
