using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    enum Style
    {
        A, F
    }
    internal class MandolinSpec : InstrumentSpec
    {
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public string Model { get; set; }
        public Builder Builder { get; set; }
        public Style Style { get; set; }

        public MandolinSpec(Type type, Wood backWood, Wood topWood, string model, Builder builder, Style style) : base(type , backWood , topWood , builder , model)
        {
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            Model = model;
            Builder = builder;
            Style = style;
        }
        public override bool Compare(InstrumentSpec searchInstrument)
        {
            if(!base.Compare(searchInstrument)) 
                return false;
            MandolinSpec spec = (MandolinSpec)searchInstrument;
            if(!Style.Equals(spec.Style))
                return false;

            return true;
        }
    }
}
