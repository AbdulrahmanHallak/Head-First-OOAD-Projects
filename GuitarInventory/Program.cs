namespace GuitarInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            inventory.AddGuitar("V95693", "Stratocastor", Builder.FENDER, 1499.95,
                               Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("V9512", "Stratocastor", Builder.FENDER, 1549.95,
                            Type.ELECTRIC, Wood.ALDER, Wood.ALDER);

            var whatErinLikes = new Guitar("", "Stratocastor", Builder.FENDER
                , 0, Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            
            var matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars != null)
            {
                foreach(var guitar in matchingGuitars)
                {
                    Console.WriteLine($"Erin, you might like this {guitar.Builder} {guitar.Model}" +
                   $" {guitar.Type} guitar: \n " +
                   $"{guitar.BackWood} back and sides \n" +
                   $"{guitar.TopWood} top \n" +
                   $"You can have it for only {guitar.Price}$ ");
                }   
            }

            else Console.WriteLine("Sorry, Erin , We have nothing for you");

            
        }
    }
}