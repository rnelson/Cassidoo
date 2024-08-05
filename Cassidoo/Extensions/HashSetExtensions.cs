namespace Cassidoo.Extensions;

public static class HashSetExtensions
{
    internal static bool ContainSameDigits<T>(this HashSet<T> me, HashSet<T> other)
    {
        if (me.Count != other.Count)
            return false;
	
        return me.Intersect(other).Count() == me.Count;
    }
}