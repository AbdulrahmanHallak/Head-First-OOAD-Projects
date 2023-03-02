using Gary_s_GSF.Units;
using System.Diagnostics;

namespace Tester
{
    // Remember to make the classes internal when you finish
    internal class Program
    {
        static void Main(string[] args)
        {
            var unit = new Unit(2);
            var weapon = new Weapon();
            unit.AddWeapon(weapon);
            UnitTypeTest(unit);
            UnitPropertiesTest(unit);
            
            var unit1 = new Unit(1);
            unit1.SetProperty("hitpoints", "24");
            ChangingExistingProperty(unit1);
            SetGetWeapons(unit1);

            var unitlist = new List<Unit>() { new Unit(2) , new Unit(3) , new Unit(8)};
            NewUnitGroup(unitlist);

            Unit unit2= new Unit(9);
            AddingUnitsToGroup(unit2);

            RemovingUnits(unit2);
        }
        private static void UnitTypeTest(Unit unit)
        {
            unit.Type = "Infantry";
            Console.WriteLine(unit.Type);
            Console.WriteLine("Changing the Unit type");
            unit.Type = "air";
            Console.WriteLine(unit.Type);
            Console.WriteLine("test passed");
        }
        private static void UnitPropertiesTest(Unit unit)
        {
            unit.SetProperty("Fucker", "getting fucked");
            unit.SetProperty("banger", "banging");
            Console.WriteLine(unit.GetProperty("Fucker"));
            Console.WriteLine(unit.GetProperty("banger"));
            Console.WriteLine("trying to get a non existent property");
            try
            {
                Console.WriteLine(unit.GetProperty("ssss"));
            }
            catch (Exception)
            {

                Console.WriteLine("test passed");
            }
            
            
        }
        private static void ChangingExistingProperty(Unit unit) 
        {
            Console.WriteLine(unit.GetProperty("hitpoints"));
            Console.WriteLine("Changing exsiting property value");
            unit.SetProperty("hitpoints", "15");
            Console.WriteLine("Changed existeing property value");
            Console.WriteLine(unit.GetProperty("hitpoints"));
        }
        private static void SetGetWeapons(Unit unit)
        {
            var weapon = new Weapon();
            unit.AddWeapon(weapon);
            Console.WriteLine("Added a weapon" + weapon.GetHashCode() );
            Console.WriteLine("retrieved a weapon" + unit.GetWeapons()[0].GetHashCode());
            Console.WriteLine("Test Passed");
        }

        private static void NewUnitGroup(List<Unit> list)
        {
            var group = new UnitGroup(list);
            var unitgroup = group.GetUnits();
            foreach(var unit in unitgroup)
            {
                Console.WriteLine(unit.ID);
            }
        }
        private static void AddingUnitsToGroup(Unit unit)
        {
            var group = new UnitGroup();
            group.AddUnit(unit);
            Console.WriteLine(group.GetUnit(unit.ID).ID);
            Console.WriteLine("Test Passed");
        }
        private static void RemovingUnits(Unit unit)
        {
            Console.WriteLine("Adding the supplied unit");
            var group = new UnitGroup();
            group.AddUnit(unit);
            Console.WriteLine("Added the unit");
            Console.WriteLine("Trying to remove the unit");
            group.RemoveUnit(unit);
            Console.WriteLine("Removed the Unit");
            Console.WriteLine("trying to remove a unit that does not exist");
            try
            {
                group.RemoveUnit(unit.ID);
            }
            catch (Exception)
            {
                Console.WriteLine("test passed");
            }
            
        }
    }
}