using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.Subway
{
    internal readonly struct Connection : IEquatable<Connection>
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

        public override bool Equals(object? obj)
        {
            return obj is Connection connection && Equals(connection);
        }

        public bool Equals(Connection other)
        {
            // Since the connection is in both direction, object x may have "A" as station1 and "B" as station2
            // while object y may have "B" as station1 and "A" as station2.
            // The two connections are the same but each in a different direction.
            return (Station1.Equals(other.Station1) || Station1.Equals(other.Station2) ) &&
                   (Station2.Equals(other.Station2) || Station2.Equals(other.Station1) ) &&
                   String.Equals(LineName , other.LineName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Station1, Station2, LineName);
        }

        public static bool operator ==(Connection left, Connection right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Connection left, Connection right)
        {
            return !(left == right);
        }
        public override string ToString() => $"{Station1} and {Station2} are connected in {LineName}";
        
    }
}
