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
            if(specs.GetType() == typeof(GuitarSpec))
            {
                var guitar = new Guitar(serialNumber, price, (GuitarSpec)specs);
                _inventory.Add(guitar);
            }
            else
            {
                var mandolin = new Mandolin(serialNumber, price, (MandolinSpec)specs);
                _inventory.Add(mandolin);
            }
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

        public List<Guitar> SearchGuitar(GuitarSpec searchGuitar)
        {
            var matchingGuitars = new List<Guitar>();
            foreach (var guitar in _inventory)
            {
                if (guitar.Spec.Compare(searchGuitar))
                    matchingGuitars.Add((Guitar)guitar);
            }
            return matchingGuitars;
        }
        public List<Mandolin> SearchMandolin(MandolinSpec searchMandolin)
        {
            var matchingMandolin = new List<Mandolin>();
            foreach (var mandolin in _inventory)
            {
                if (mandolin.Spec.Compare(searchMandolin))
                    matchingMandolin.Add((Mandolin)mandolin);
            }
            return matchingMandolin;
        }

    }
}
