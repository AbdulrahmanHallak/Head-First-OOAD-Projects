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
            try
            {
                Thread.Sleep(5000) ;
            }
            catch (ThreadInterruptedException e)
            {
                throw;
            }
            Console.WriteLine("Fido is all done");
            Console.Write("but the door is closed");
            Console.WriteLine(" andfido is stuck outside");
            Console.WriteLine("so he starts barking");
            Console.WriteLine("gina grabs the remote");
            remote.PressButton();
            Console.Read();
        }
    }
}