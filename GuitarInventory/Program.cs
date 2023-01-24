namespace GuitarInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            inventory.AddGuitar("V95693", 1499.95, new GuitarSpec {Builder= Builder.Fender ,Type= GuitarType.Electric ,
                                                        BackWood = Wood.Alder , TopWood = Wood.Alder , Model = "Stratocastor" , NumStrings = 6});

            inventory.AddGuitar("V9512",1596.95, new GuitarSpec {Builder = Builder.Collings, Type = GuitarType.Electric, BackWood = Wood.Alder,
                                        TopWood = Wood.Alder,  Model = "Stratocastor", NumStrings = 12 });

            var whatErinLikes = new GuitarSpec("Stratocastor", Builder.Collings,
                                           GuitarType.Electric, Wood.Alder, Wood.Alder , 12);
            
            var matchingGuitars = inventory.Search(whatErinLikes);
            
            if (matchingGuitars.Any())
            {
                foreach(var guitar in matchingGuitars)
                {
                    Console.WriteLine($"Erin, you might like this {guitar.Spec.Builder} {guitar.Spec.Model}" +
                   $" {guitar.Spec.Type} guitar: \n " +
                   $"{guitar.Spec.BackWood} back and sides \n" +
                   $"{guitar.Spec.TopWood} top \n" +
                   $"You can have it for only {guitar.Price}$ ");
                }   
            }

            else Console.WriteLine("Sorry, Erin , We have nothing for you");

            
        }
    }
}