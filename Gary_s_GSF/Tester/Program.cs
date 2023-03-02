using Gary_s_GSF.Units;
namespace Tester
{
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

    }
}