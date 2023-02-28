using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor
{
    internal class Bark : IEquatable<Bark>
    {
        private string _barkSound;
        public Bark(string barkSound)
        {
            _barkSound = barkSound;
        }

        public override bool Equals(object? obj) => this.Equals(obj as Bark);

        public bool Equals(Bark? other)
        {
            if (other is null) return false;
            if (Object.ReferenceEquals(this, other)) return true;
            return String.Equals(other._barkSound.ToLower(), _barkSound.ToLower());
        }

        public string GetBarkSound()
        {
            return _barkSound;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_barkSound);
        }

        public static bool operator ==(Bark? left, Bark? right)
        {
            if(left == null)
            {
                // null == null = true
                if(right == null) return true;

                return false;
            }
            return left.Equals(right);
        }

        public static bool operator !=(Bark? left, Bark? right) => !(left == right);
    }
}
