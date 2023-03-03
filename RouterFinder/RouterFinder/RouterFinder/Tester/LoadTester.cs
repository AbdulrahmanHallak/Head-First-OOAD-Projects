using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouterFinder.Loader;
using RouterFinder.Subway;

namespace RouterFinder.Tester
{
    internal class LoadTester
    {
        static void Main(string[] args)
        {
            SubwayLoader loader = new SubwayLoader();
            Subway.Subway subway = loader.LoadFromFile("C:\\Users\\Abdulrahman\\Desktop\\New Text Document.txt");
            Console.WriteLine("Testing Stations...");
            if (subway.HasStation("Head First Theater") && subway.HasStation("Choc-O-Holic, Inc.") && subway.HasStation("XHTML Expressway"))
                Console.WriteLine("Test Passed");

            Console.WriteLine("Testing Connections...");
            if (subway.HasConnection("Head First Theater", "DRY Dive", "Meyer Line") &&
                subway.HasConnection("UML Walk", "The TIKIBEAN LOUNGE", "Wirfs-Brock Line") &&
                subway.HasConnection("Head First Theater", "Infinite Circle", "Rumbaugh Line"))
                Console.WriteLine("Test Passed");

            subway.TestAllSations();
        }
    }
}
