using System.Text;

namespace GuitarInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invetory = new Inventory();
            //InventoryInitializer.InitializeInventory(invetory);
            TestInstrumentSearch();
        }
        //A method to test the search method with hard-coded values
        public static void TestInstrumentSearch()
        {
            // Set up Rick's instrument inventory
            var inventory = new Inventory();
            InventoryInitializer.InitializeInventory(inventory);

            var guitarSpec = new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Fender},
                { "type", Type.Electric},
                { "topWood", Wood.Alder},
                { "backWood", Wood.ADERONDACK},
                { "numStrings", NumberOfStrings.six}
            };
            var whatErinLikes = new InstrumentSpec(guitarSpec);
            FindInstrument("Erin", whatErinLikes, inventory);


            var mandolinSpec = new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Mandolin },
                { "builder", Builder.Fender},
                { "type", Type.Acoustic},
                { "topWood", Wood.Alder},
                { "backWood", Wood.Alder},
                { "style", Style.A}
             };
            var whatPhilLikes = new InstrumentSpec(mandolinSpec);
            FindInstrument("Phil", whatPhilLikes, inventory);

            var multiInstrumentSpec = new Dictionary<string, System.Enum>
            {
                { "builder", Builder.Gibson},
                { "backWood", Wood.Maple},
            };
            var whatSallyLikes = new InstrumentSpec(multiInstrumentSpec);
            FindInstrument("Sally", whatSallyLikes, inventory);
        }
        //A method that class the search method to test and print out the result.
        //Note: Too lazy to make a specific method for printing out the resutl.
        private static void FindInstrument(string name, InstrumentSpec instrumentSpec, Inventory inventory)
        {
            if (inventory == null) Console.WriteLine("the invenroy is empty");
            List<Instrument> matchingInstruments = inventory.Search(instrumentSpec);
            if(matchingInstruments != null)
            {
                foreach (Instrument instrument in matchingInstruments)
                {
                    //Enumerate through each instrument in matchingInstrumnet.
                    Console.WriteLine($"Hello, {name}.\nWe have this {instrument.Spec.Properties["instrumentType"]} with the following specs");
                    foreach(string propertyKey in instrument.Spec.Properties.Keys)
                    {
                        //Enumerate through the Properties Dictionary of each instrument
                        Console.WriteLine($"{propertyKey.PadRight(20)}{instrument.Spec.Properties[propertyKey]}");
                    }
                    Console.WriteLine("\n");
                }
            }else
            Console.WriteLine("we have nothing for you");
          
        }
    }
}