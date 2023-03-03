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
            _subway= new Subway.Subway();
        }

        public Subway.Subway LoadFromFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);

            LoadStations(_subway, reader);
            string lineName = reader.ReadLine();
            while(!String.IsNullOrEmpty(lineName))
            {
                LoadLine(_subway, reader , lineName);
                lineName = reader.ReadLine();
            }
            return _subway;

        }

        private void LoadStations(Subway.Subway subway , StreamReader reader)
        {
            string currentLine = reader.ReadLine();
            while((!reader.EndOfStream) &&  (currentLine.Length > 0))
            {
                subway.AddStation(currentLine);
                currentLine = reader.ReadLine();
            }
        }
        private void LoadLine(Subway.Subway subway, StreamReader reader , string lineName) 
        {
            string stationOneName = reader.ReadLine();
            string stationTwoName = reader.ReadLine();
            while((!reader.EndOfStream) && (!String.IsNullOrEmpty(stationTwoName)))
            {
                subway.AddConnection(stationOneName, stationTwoName , lineName);
                stationOneName = stationTwoName;
                stationTwoName = reader.ReadLine();
            }
        }
    }
}
