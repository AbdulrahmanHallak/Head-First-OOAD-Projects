using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class InstrumentSpec
    {   
        // Made the TValue of type System.Enum to ensure type safety
        // instead of making it of type Object which is prone to error.
        // Stored the properties in a Dictionary because they vary
        // with each instrument.
        public Dictionary<string, System.Enum> Properties { get; set; }

        public InstrumentSpec(Dictionary<string , System.Enum> properties)
        {
           Properties= properties;
        }

        // No need to override the Equals method as all the properties are of type Enum
        public bool Compare(InstrumentSpec searchInstrument)
        {
            foreach (string propertyKey in searchInstrument.Properties.Keys)
            {
                // If the match failed for a single property it returns false
                // otherwise it keeps going through all the properties and returns true.
                if (!Properties[propertyKey].Equals(searchInstrument.Properties[propertyKey]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
