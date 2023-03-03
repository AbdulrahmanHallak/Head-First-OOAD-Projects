using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.Subway
{
    internal class Station : IEquatable<Station>
    {
        public Station(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override bool Equals(object? obj) => this.Equals(obj as Station);

        public override int GetHashCode()
        {
            return HashCode.Combine(Name.ToLower());
        }

        bool IEquatable<Station>.Equals(Station? other)
        {
            if (other is null) return false;
            if (Object.ReferenceEquals(other, this)) return true;
            return String.Equals(other.Name.ToLower(), Name.ToLower());
        }

        public static bool operator ==(Station? left, Station? right)
        {
            if(left is null)
            {
                // null == null = true.
                if (right is null)
                    return true;

                return false;
            }
            return left.Equals(right);
        }

        public static bool operator !=(Station? left, Station? right)
        {
            return !(left == right);
        }
    }
}
