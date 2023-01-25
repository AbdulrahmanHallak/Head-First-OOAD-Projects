namespace DogDoor
{
    internal class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            var door = new Door();
            var remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside");
            Console.Read();
            Console.WriteLine("Fido is all doen");
            remote.PressButton();
            Console.WriteLine("fido is back inside");
            Console.Read();
            Console.Read();
        }
    }
}