namespace MyHashSet;

public class MyHashSet<T>(int capacity = 10)
{
    private readonly List<T> _list = new(capacity);
    private readonly List<int> _hash = new(capacity);
    
    /// <summary>
    /// Adds item to HashSet if it doesn't exist.
    /// </summary>
    public void Add(T type)
    {
        if (type == null) return;
        
        if (capacity == _list.Count) throw new Exception("Hashset is full")
        
        int hash = type.GetHashCode();
        if (!_hash.Contains(hash))
        {
            _list.Add(type);
            _hash.Add(hash);
        }
        
         
    }
    
    /// <summary>
    /// Removes item from HashSet.
    /// </summary>
    public void Remove(T type)
    {
        if (!Contains(type)) return;
        _list.Remove(type);
    }

    /// <summary>
    /// Checks if item exists in HashSet.
    /// </summary>
    public bool Contains(T type)
    {
        return _list.Contains(type);
    }
    
    public int Count => _list.Count;
    
    public override string ToString() => string.Join(", ", _list);
}