using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.Subway
{
    internal class Subway
    {
        private List<Station> _stations;
        private List<Connection> _connections;

        public Subway()
        {
            _stations = new List<Station>();
            _connections = new List<Connection>();
        }

        public void AddStation(string stationName)
        {
            if (String.IsNullOrEmpty(stationName)) throw new ArgumentNullException();

            if (!HasStation(stationName))
            {
                var station = new Station(stationName);
                _stations.Add(station);
            }
        }

        public void AddConnection(string stationOneName, string stationTwoName , string lineName)
        {
            if(String.IsNullOrEmpty(stationOneName)) throw new ArgumentNullException();
            if(String.IsNullOrEmpty(stationTwoName)) throw new ArgumentNullException();
            if(String.IsNullOrEmpty(lineName)) throw new ArgumentNullException();

            if ((!HasStation(stationOneName)) || (!HasStation(stationTwoName)))
                Console.WriteLine("there is no stations with these names");

            // It is easier to create new object than to iterate through the list to get it.
            var station1= new Station(stationOneName);
            var station2 = new Station(stationTwoName);

            var connecntion = new Connection(station1, station2 , lineName);
            _connections.Add(connecntion);
            // Since the subway goes in both directions we added two connections.
            var oppositeDirectionConnection = new Connection(station2, station1, lineName);
            _connections.Add(oppositeDirectionConnection);
        }
        // This method should be private but made it public for testing.
        public bool HasStation(string stationName) { return _stations.Contains<Station>(new Station(stationName)); }

        // This method is just for testing, the actual system does not need it.
        public bool HasConnection(string stationOneName , string stationTwoName , string lineName)
        {
            var station1 = new Station(stationOneName);
            var station2 = new Station(stationTwoName);
            var connecntion = new Connection(station1, station2 , lineName);
            return _connections.Contains(connecntion);
        }

        public void TestAllSations()
        {
            foreach(Station station in _stations)
            {
                Console.WriteLine(station.Name);
            }
            Console.WriteLine("Number of stations {0}" , _stations.Count);
        }
    }
}
