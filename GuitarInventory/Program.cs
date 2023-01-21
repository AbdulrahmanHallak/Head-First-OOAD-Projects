namespace GuitarInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            inventory.AddGuitar("V95693", "Stratocastor", Builder.Fender, 1499.95,
                                GuitarType.Electric, Wood.Alder, Wood.Alder);

            inventory.AddGuitar("V9512", "Stratocastor", Builder.Fender, 1549.95,
                                 GuitarType.Electric, Wood.Alder, Wood.Alder);

            var whatErinLikes = new GuitarSpec("Stratocastor", Builder.Fender,
                                           GuitarType.Electric, Wood.Alder, Wood.Alder);
            
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