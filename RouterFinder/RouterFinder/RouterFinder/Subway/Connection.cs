using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.Subway
{
    internal class Connection
    {
        public string Station1 { get; private set;}
        public string Station2 { get; private set;}
        public string LineName { get; private set;}

        public Connection(string station1, string station2, string lineName)
        {
            Station1 = station1;
            Station2 = station2;
            LineName = lineName;
        }
    }
}
