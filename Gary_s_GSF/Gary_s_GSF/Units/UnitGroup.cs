using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gary_s_GSF.Units
{
    public class UnitGroup
    {
        private Dictionary<int, Unit> _units;

        public UnitGroup(List<Unit> units)
        {
            _units = new Dictionary<int, Unit>();
            foreach(Unit unit in units)
            {
                _units.Add(unit.ID, unit);
            }
        }
        public UnitGroup()
        {
            _units= new Dictionary<int, Unit>();
        }

        public void AddUnit(Unit unit)
        {
            if (unit is null) throw new ArgumentNullException(nameof(unit));

            _units.Add(unit.ID, unit);
        }
        public Unit GetUnit(int ID)
        {
            if(!_units.ContainsKey(ID)) 
                throw new NullReferenceException("these in no unit with the supplied ID");

            return _units[ID];
        }
        public void RemoveUnit(int ID)
        {
            if(!_units.ContainsKey(ID))
                throw new NullReferenceException("there is no unit with supplied ID");

            _units.Remove(ID);
        }
        public void RemoveUnit(Unit unit)
        {
            if(!_units.ContainsKey(unit.ID))
                throw new KeyNotFoundException("These is no unit in the group with this ID");

            _units.Remove(unit.ID);
        }
        public List<Unit> GetUnits()
        {
            if(!_units.Any())
                throw new NullReferenceException("The group is empty");

            var units = new List<Unit>();
            foreach (var unit in _units)
            {
                units.Add(unit.Value);
            }
            return units;   
        }
    }
}
