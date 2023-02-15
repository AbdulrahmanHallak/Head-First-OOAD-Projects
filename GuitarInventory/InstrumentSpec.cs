using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class InstrumentSpec
    {   
        //Made the TValue of type System.Enum to ensure type safety
        //instead of making it of type Object which is prone to error.
        public Dictionary<string, System.Enum> Properties { get; set; }

        public InstrumentSpec(Dictionary<string , System.Enum> properties)
        {
           Properties= properties;
        }

        public bool Compare(InstrumentSpec searchInstrument)
        {
            foreach (string propertyKey in searchInstrument.Properties.Keys)
            {
                //if the match failed for a single property it returns false
                //otherwise it keeps going through all the properties and returns true.
                if (!Properties[propertyKey].Equals(searchInstrument.Properties[propertyKey]))
                {
                    return false;
                }
            }
            return true;
        }
     /*   public System.Enum GetProperty(string key)
        {
            if(Properties.ContainsKey(key)) return Properties[key];
            return null;
        }*/
    }
}
