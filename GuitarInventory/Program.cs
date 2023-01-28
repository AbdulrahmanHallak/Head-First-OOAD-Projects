namespace GuitarInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            inventory.AddInstrument("V95693", 1499.95, new GuitarSpec("Stratocastor" , Builder.Fender , Type.Electric , Wood.Alder , Wood.Alder , 6));

            inventory.AddInstrument("V9512",1596.95, new MandolinSpec(Type.Acoustic , Wood.Alder , Wood.Alder , "Stratocastor" , Builder.Fender , Style.A));

            var whatErinLikes = new GuitarSpec("Stratocastor", Builder.Fender, Type.Electric, Wood.Alder, Wood.Alder, 4);
            
            var matchingGuitars = inventory.SearchGuitar(whatErinLikes);
            
            if (matchingGuitars.Count != 0)
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