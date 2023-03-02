using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gary_s_GSF.Units
{
    public class Unit
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int ID { get; private set; }
        private List<Weapon> _weapons;
        private Dictionary<string, string> _properties;
        public Unit(int id) 
        {
            ID = id;
        }

        public void AddWeapon(Weapon weapon)
        {
            if(_weapons is null) _weapons = new List<Weapon>();
            if (weapon is not null) _weapons.Add(weapon);
            else
            throw new ArgumentNullException(nameof(weapon));
        }
        public List<Weapon> GetWeapons() => _weapons;
        public void SetProperty(string name, string value)
        {
            // Check if the Dictionary has been initialized.
            if(_properties is null) _properties = new Dictionary<string, string>();

            if(String.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name), "You must assign a name to the property");
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value) , "You must assign a value to the property");

            // In case this method is called to modift an exsiting property
            if(!_properties.ContainsKey(name))
                _properties.Add(name, value);

            _properties[name] = value;
        }
        public string GetProperty(string name)
        {
            if (_properties is null) throw new NullReferenceException(nameof(_properties) + "The properties are null");

            if(_properties.TryGetValue(name, out var value))
                return name.PadRight(10) + value;

            throw new NullReferenceException("There is no such property");
        }

    }
}
