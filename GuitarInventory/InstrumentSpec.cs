using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal abstract class InstrumentSpec
    {   
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public string Model { get; set; }
        public Wood TopWood { get; set; }
        public Builder Builder { get; set; }

        public InstrumentSpec(Type type, Wood backWood, Wood topWood, Builder builder , string model)
        {
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            Builder = builder;
            Model = model;
        }

        public virtual bool Compare(InstrumentSpec searchInstrument)
        {
            //ignore price because that is unique
            //ignore serial number because that is unique
            var builder = searchInstrument.Builder;
            if (!builder.Equals(Builder))
                return false;

            var model = searchInstrument.Model.ToLower();
            if ((model != null) && !model.Equals("") && (!model.Equals(Model.ToLower())))
                return false;

            var type = searchInstrument.Type;
            if (!type.Equals(Type))
                    return false;

            var backWood = searchInstrument.BackWood;
            if (!backWood.Equals(BackWood))
                    return false;

            var topWood = searchInstrument.TopWood;
            if (!topWood.Equals(TopWood))
                    return false;

                return true;
        }
    }
}
