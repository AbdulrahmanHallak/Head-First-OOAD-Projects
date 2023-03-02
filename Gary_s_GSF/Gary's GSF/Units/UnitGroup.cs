using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gary_s_GSF.Units
{
    internal class UnitGroup
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
            return _units[ID];
        }
        public void RemoveUnit(int ID)
        {
            _units.Remove(ID);
        }
        public List<Unit> GetUnits()
        {
            var units = new List<Unit>();
            if(_units is not null)
            {
                foreach(var unit in _units)
                {
                    units.Add(unit.Value);
                }
                return units; 
            }
            throw new NullReferenceException("You have not created a group");
        }
    }
}
