using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class Inventory
    {
        private List<Guitar> _guitarList;

        public Inventory()
        {
            this._guitarList = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber,double price , GuitarSpec specs)
        {
            var guitar = new Guitar(serialNumber, price, specs);
            _guitarList.Add(guitar);
        }
        public Guitar GetGuitar(string serialNumber)
        {
            for (int i = 0; i < _guitarList.Count; i++)
            {
                if (_guitarList[i].SerialNumber.Equals(serialNumber))
                    return _guitarList[i];

            }
            return null;
        }

        public LinkedList<Guitar> Search(GuitarSpec searchGuitar)
        {
            var matchingGuitars = new LinkedList<Guitar>();
            foreach(var guitar in _guitarList)
            {
                if(guitar.Spec.Compare(searchGuitar))
                    matchingGuitars.AddLast(guitar) ;
            }
            return matchingGuitars;
        }
    }
}
