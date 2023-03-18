using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.Subway
{
    internal readonly struct Connection
    {
        public Station Station1 { get;}
        public Station Station2 { get;}
        public string LineName { get;}

        public Connection(Station station1, Station station2, string lineName)
        {
            Station1 = station1;
            Station2 = station2;
            LineName = lineName;
        }
    }
}
