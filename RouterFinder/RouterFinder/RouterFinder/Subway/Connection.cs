using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.Subway
{
    internal struct Connection
    {
        public Station Station1 { get; private set;}
        public Station Station2 { get; private set;}
        public string LineName { get; private set;}

        public Connection(Station station1, Station station2, string lineName)
        {
            Station1 = station1;
            Station2 = station2;
            LineName = lineName;
        }
    }
}
