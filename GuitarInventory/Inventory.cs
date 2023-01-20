using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    public enum Type
    {
        ACOUSTIC,
        ELECTRIC
    }
    public enum Builder
    {
        FENDER , MARTIN , GIBSON , COLLINGS , OLSON , RYAN , PRS , ANY
  
    }
    public enum Wood
    {
        INDIAN_ROSEWOOD , BRAZILIAN_ROSEWOOD , MAHOGANY , MAPLE , COCOBOLO , CEDAR , ADERONDACK , ALDER , SITKA
    }

    internal class Inventory
    {
        private List<Guitar> _guitarList;

        public Inventory()
        {
            this._guitarList = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, string model, Builder builder,
                              double price, Type type, Wood backwood, Wood topwood)
        {
            Guitar guitar = new Guitar(serialNumber, model, builder,
                                      price, type, backwood, topwood);
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

        public LinkedList<Guitar> search(Guitar searchGuitar)
        {
            var matchingGuitars = new LinkedList<Guitar>();
            for(int i = 0; i < _guitarList.Count; i++)
            {
                Guitar guitar = _guitarList[i];
                var builder = searchGuitar.Builder;
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.Builder)))
                    continue;

                string model = searchGuitar.Model.ToLower();
                if((model != null) && !model.Equals("") && (!model.Equals(guitar.Model.ToLower())))
                        continue;

                var type = searchGuitar.Type;
                if((type != null) && (!type.Equals("")) && (!type.Equals(guitar.Type)))
                    continue;

                var backWood = searchGuitar.BackWood;
                if((backWood != null) && (backWood.Equals("")) && (!backWood.Equals(guitar.BackWood)))
                    continue;

                var topWood = searchGuitar.TopWood;
                if((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.TopWood)))
                    continue;
                matchingGuitars.AddLast(guitar);
            }
            return matchingGuitars;
        }
    }
}
