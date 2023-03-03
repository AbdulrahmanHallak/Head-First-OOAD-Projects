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
        private bool HasStation(string stationName) { return _stations.Contains(new Station(stationName)); }

        public void AddConnection(string stationOneName, string stationTwoName)
        {
            if(String.IsNullOrEmpty(stationOneName)) throw new ArgumentNullException();
            if(String.IsNullOrEmpty(stationTwoName)) throw new ArgumentNullException();



        }
    }
}
