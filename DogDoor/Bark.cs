namespace DogDoor;

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
        return HashCode.Combine(_barkSound.ToLower());
    }

    public static bool operator ==(Bark? left, Bark? right)
    {
        if(left is null)
        {
            // null == null = true
            if(right is null) return true;

            return false;
        }
        return left.Equals(right);
    }

    public static bool operator !=(Bark? left, Bark? right) => !(left == right);
}
