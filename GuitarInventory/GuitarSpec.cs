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
        public int NumStrings { get; set; }

        public GuitarSpec(string model , Builder builder, GuitarType type, Wood backWood, Wood topWood, int numStrings)

        {
            this.Model = model;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.Builder = builder;
            this.Type = type;
            this.Builder = builder;
            NumStrings = numStrings;
        }
        public GuitarSpec()
        {

        }
        public bool Compare(GuitarSpec searchGuitar)
        {
            var builder = searchGuitar.Builder;
            if (!builder.Equals(Builder))
                return false;

            var numStrings = searchGuitar.NumStrings;
            if(numStrings != 0 && numStrings != this.NumStrings)
                return false;

            var model = searchGuitar.Model.ToLower();
            if ((model != null) && !model.Equals("") && (!model.Equals(Model.ToLower())))
                    return false;

            var type = searchGuitar.Type;
            if (!type.Equals(Type))
                    return false;

            var backWood = searchGuitar.BackWood;
            if (!backWood.Equals(BackWood))
                    return false;

            var topWood = searchGuitar.TopWood;
            if (!topWood.Equals(TopWood))
                    return false;

                return true;
        }
    }
}
