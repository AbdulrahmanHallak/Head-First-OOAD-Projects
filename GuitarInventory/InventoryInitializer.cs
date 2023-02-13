using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class InventoryInitializer
    { 
        public static void InitializeInventory(Inventory inventory)
        {
            InitializeGuitarInventory(inventory);
            InitializeMandolinInventory(inventory);
            InitializeBanjosInventory(inventory);
        }

        private static void InitializeGuitarInventory(Inventory inventory)
        {
            // Add Guitars to the inventory ...
            inventory.AddInstrument("V12345", 1345.55, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Fender},
                { "type", Type.Electric},
                { "topWood", Wood.Alder},
                { "backWood", Wood.ADERONDACK},
                { "numStrings", NumberOfStrings.six}
            }));

            inventory.AddInstrument("A21457", 900.55, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Collings},
                { "type", Type.Acoustic},
                { "topWood", Wood.BRAZILIAN_ROSEWOOD},
                { "backWood", Wood.Cedar},
                { "numStrings", NumberOfStrings.six}
            }));

            inventory.AddInstrument("X54321", 430.54, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Martin},
                { "type", Type.Electric},
                { "topWood", Wood.INDIAN_ROSEWOOD},
                { "backWood", Wood.Maple},
                { "numStrings", NumberOfStrings.six}
            }));

            inventory.AddInstrument("X9987NumberOfStrings.six", 2000.00, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.PRS},
                { "type", Type.Electric},
                { "topWood", Wood.Sitka},
                { "backWood", Wood.Cocobolo},
                { "numStrings", NumberOfStrings.six}
            }));

            inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Collings},
                { "type", Type.Acoustic},
                { "topWood", Wood.Spruce},
                { "backWood", Wood.INDIAN_ROSEWOOD },
                { "numStrings", NumberOfStrings.six}
            }));

            inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Martin},
                { "type", Type.Acoustic},
                { "topWood", Wood.ADERONDACK},
                { "backWood", Wood.Mahogany },
                { "numStrings", NumberOfStrings.six}
            }));

            inventory.AddInstrument("", 1890.95, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Gibson},
                { "type", Type.Electric},
                { "topWood", Wood.Mahogany},
                { "backWood", Wood.Mahogany },
                { "numStrings", NumberOfStrings.six}
            }));

            inventory.AddInstrument("", 2295.95, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Guitar },
                { "builder", Builder.Gibson},
                { "type", Type.Electric},
                { "topWood", Wood.Maple},
                { "backWood", Wood.Maple },
                { "numStrings", NumberOfStrings.six}
            }));
        }

        private static void InitializeMandolinInventory(Inventory inventory)
        {
            // Add Mandolins to the inventory ...
            inventory.AddInstrument("X12345", 1745.55, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Mandolin },
                { "builder", Builder.Fender},
                { "type", Type.Electric},
                { "topWood", Wood.Alder},
                { "backWood", Wood.ADERONDACK},
                { "style", Style.A}
            }));

            inventory.AddInstrument("Q21457", 1200.55, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Mandolin },
                { "builder", Builder.Collings},
                { "type", Type.Acoustic},
                { "topWood", Wood.BRAZILIAN_ROSEWOOD},
                { "backWood", Wood.Cedar},
                { "style", Style.F}
            }));

            inventory.AddInstrument("", 699.95, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Mandolin },
                { "builder", Builder.Fender},
                { "type", Type.Acoustic},
                { "topWood", Wood.Alder},
                { "backWood", Wood.Alder},
                { "style", Style.A}
            }));

            inventory.AddInstrument("9019920", 5495.99, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Mandolin },
                { "builder", Builder.Gibson},
                { "type", Type.Acoustic},
                { "topWood", Wood.Maple},
                { "backWood", Wood.Maple},
                { "style", Style.A}
            }));
        }

        private static void InitializeBanjosInventory(Inventory inventory)
        {
            inventory.AddInstrument("8900231", 2945.95, new InstrumentSpec(new Dictionary<string, System.Enum>
            {
                { "instrumentType", InstrumentType.Banjo },
                { "builder", Builder.Gibson },
                { "type", Type.Acoustic },
                {"topWood", Wood.Maple },
                { "backWood", Wood.Maple },
                { "style", Style.F }
            }));
        }
    }
}
