using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RouterFinder.Loader;
using RouterFinder.Subway;

namespace RouterFinder.Loader
{
    internal class SubwayLoader
    {
        private Subway.Subway _subway;
        public SubwayLoader()
        {
            _subway = new Subway.Subway();
        }

        public Subway.Subway LoadFromFile(string filePath)
        {
            // Close the StreamReader at the end of the scope with "using declaration".
            using var reader = new StreamReader(filePath);
                
            LoadStations(_subway, reader);
            string lineName = reader.ReadLine();
            while (!String.IsNullOrEmpty(lineName))
            {
                LoadLine(_subway, reader, lineName);
                lineName = reader.ReadLine();
            } 
            return _subway;
        }

        private static void LoadStations(Subway.Subway subway , StreamReader reader)
        {
            string currentLine = reader.ReadLine();
            while((!reader.EndOfStream) &&  (currentLine.Length > 0))
            {
                subway.AddStation(currentLine);
                currentLine = reader.ReadLine();
            }
        }
        private static void LoadLine(Subway.Subway subway, StreamReader reader , string lineName) 
        {
            string stationOneName = reader.ReadLine();
            string stationTwoName = reader.ReadLine();
            while((!reader.EndOfStream) && (!String.IsNullOrEmpty(stationTwoName)))
            {
                // When the exception is thrown, we just inform the user of it, ignoring the connection that caused the error and proceeding with the application.
                try
                {
                    subway.AddConnection(stationOneName, stationTwoName, lineName);
                }
                catch (Exception e)
                {
                    // If the station that was not provided in the stations' section is in the middle of the line then it will first be stored in the stationTwoName
                    // then we will move it to stationOneName to connect it with the next station i.e. the third station.
                    // The reason behind this if is that if the scenario above is true we must bypass throwing two exceptions because of a single faulty station without
                    // affecting the system. And we do so by skipping the step where the station gets stored in the stationOneName in the catch block.
                    // While if the scenario is not true i.e. the faulty station was at beginning of the line, then it will be stored in the stationOneName,
                    // meaning we will only come across it once so there is no need to skip a step.
                    if (e.Message.Contains(stationTwoName))
                    {
                        stationOneName = stationTwoName;
                        stationTwoName = reader.ReadLine();
                    }
                    Console.WriteLine(e.Message);
                }
                stationOneName = stationTwoName;
                stationTwoName = reader.ReadLine();
            }
        }
    }
}
