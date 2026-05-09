namespace MyHashSet;

public class MyHashSet<T>(int capacity = 10) where T : notnull
{
    private readonly Dictionary<int, T> _list = new(capacity);
    
    /// <summary>
    /// Adds item to HashSet if it doesn't exist.
    /// </summary>
    public void Add(T? value)
    {
        if (value == null)
            return;

        if (capacity <= _list.Count) throw new Exception("Hashset is full");
        
        int hash = value.GetHashCode();
        
        _list.TryAdd(key: hash, value: value);
    }
    
    /// <summary>
    /// Removes item from HashSet.
    /// </summary>
    public void Remove(T? value)
    {
        if (value == null)
            return;
        
        if (!Contains(value))
            return;
        
        _list.Remove(value);
    }

    /// <summary>
    /// Checks if item exists in HashSet.
    /// </summary>
    public bool Contains(T? value)
    {
        if (value == null)
            return false;
        
        return _list.ContainsValue(value.GetHashCode());
    }
    
    public override string ToString() => string.Join(", ", _list);
}