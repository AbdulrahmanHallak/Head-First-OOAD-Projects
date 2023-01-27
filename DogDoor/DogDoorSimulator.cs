namespace DogDoor
{
    internal class DogDoorSimulator
    {
        static void Main(string[] args)
        {
         
            var door = new Door();
            door.AddAllowedBarks(new Bark("rowlf"));
            door.AddAllowedBarks(new Bark("roowlf"));
            door.AddAllowedBarks(new Bark("rawlf"));
            door.AddAllowedBarks(new Bark("woof"));

            var barkRecognizer = new BarkRecognizer(door);
            var remote = new Remote(door);

            //Simulate the hardware hearing a bark
            Console.WriteLine("Bruce starts barking");
            barkRecognizer.Recognize(new Bark("rowlf"));

            Console.WriteLine("bruce has gone outside");
            try
            {
                Thread.Sleep(5000) ;
            }
            catch (ThreadInterruptedException e)
            {
                throw;
            }
            Console.WriteLine("Bruce is all done with his business");
            Console.WriteLine("But he is stuck outside");

            //Simulate the hardware hearing a bark (not Bruce)
            var smallDogBark = new Bark("yip");
            barkRecognizer.Recognize(smallDogBark);

            try
            {
                Thread.Sleep(5000);
            }
            catch (ThreadInterruptedException e)
            {
                throw;
            }

            //Simulate the hardware hearing a bark again
            Console.WriteLine("Bruce starts barking again");
            barkRecognizer.Recognize(new Bark("roowlf"));
            Console.Read();

        }
    }
}