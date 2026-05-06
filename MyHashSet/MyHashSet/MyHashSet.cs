namespace MyHashSet;

public class MyHashSet<T>(int capacity = 10)
{
    private readonly List<T> _list = new(capacity);
    private readonly List<int> _hash = new(capacity);
    
    /// <summary>
    /// Adds item to HashSet if it doesn't exist.
    /// </summary>
    public void Add(T value)
    {
        if (value == null)
            return;

        if (capacity <= _list.Count) throw new Exception("Hashset is full");
        
        int hash = value.GetHashCode();
        
        if (_hash.Contains(hash))
            return;
        
        _list.Add(value);
        _hash.Add(hash);
    }
    
    /// <summary>
    /// Removes item from HashSet.
    /// </summary>
    public void Remove(T value)
    {
        if (value == null)
            return;
        
        if (!Contains(value))
            return;
        
        _list.Remove(value);
        _hash.Remove(value.GetHashCode());
    }

    /// <summary>
    /// Checks if item exists in HashSet.
    /// </summary>
    public bool Contains(T value)
    {
        if (value == null)
            return false;
        
        return _hash.Contains(value.GetHashCode());
    }
    
    public override string ToString() => string.Join(", ", _list);
}