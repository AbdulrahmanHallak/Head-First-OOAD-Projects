using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class Inventory
    {
        private List<Instrument> _inventory;

        public Inventory()
        {
            this._inventory = new List<Instrument>();
           
        }

        public void AddInstrument(string serialNumber,double price , InstrumentSpec specs)
        {
           var instrument = new Instrument(serialNumber, price, specs);
            this._inventory.Add(instrument);
        }
        public Instrument GetInstrument(string serialNumber)
        {
            foreach(var instrument in _inventory)
            {
                if(instrument.SerialNumber.Equals(serialNumber))
                    return instrument;
            }
            return null;
        }

        public List<Instrument> Search(InstrumentSpec searchSpec)
        {
            var matchingInstruments = new List<Instrument>();
            foreach (var instrument in _inventory)
            {
                if (instrument.Spec.Compare(searchSpec))
                    matchingInstruments.Add(instrument);
            }
            return matchingInstruments;
        }
    }
}
