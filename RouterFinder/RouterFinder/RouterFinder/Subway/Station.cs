using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.Subway
{
    internal readonly struct Station : IEquatable<Station>
    {
        public Station(string name)
        {
            Name = name;
        }

        public string Name { get;}

        public override bool Equals(object? obj) => obj is Station other && Equals(other);

        public bool Equals(Station other)
        {
            return String.Equals(other.Name, Name , StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public static bool operator ==(Station left, Station right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Station left, Station right)
        {
            return !(left == right);
        }
        public override string ToString() => Name;
    }
}
