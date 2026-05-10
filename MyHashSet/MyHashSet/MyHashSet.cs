namespace MyHashSet;

public class MyHashSet<T>(int capacity = 10) where T : notnull
{
    private readonly Dictionary<int, T> _list = new(capacity);
    
    /// <summary>
    /// Adds item to HashSet if it doesn't exist. Will throw exception if HashSet is full.
    /// </summary>
    public void Add(T? value)
    {
        if (value == null)
            return;

        if (capacity <= _list.Count) throw new Exception("Hashset is full");
        
        int hash = value.GetHashCode();

        _list.TryAdd(hash, value);
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
        
        _list.Remove(value.GetHashCode());
    }

    /// <summary>
    /// Checks if item exists in HashSet.
    /// </summary>
    public bool Contains(T? value)
    {
        if (value == null)
            return false;
        
        return _list.ContainsValue(value);
    }

    /// <summary>
    /// Recursively tries to add item to HashSet, adds randomisation to avoid collisions.
    /// </summary>
    private bool TryToAdd(int key, T value)
    {
        if (_list.TryAdd(key, value))
            return true;

        if (_list.ContainsValue(value))
            return false;
        
        Random random = new();
        key += random.Next(-(2^32), 2^32);
        
        TryToAdd(key, value);
        return false;
    }
    
    /// <summary>
    /// Returns a string representation of the HashSet.
    /// </summary>
    public override string ToString()
    {
        string result = "";
        foreach (KeyValuePair<int, T> item in _list)
        {
            result += item.Value.ToString();
            result += ", ";
        }
        result = result.TrimEnd(',',' ');
        return result;
    }
    
    /// <summary>
    /// Returns the number of items in the HashSet, NOT the capacity.
    /// </summary>
    public int Count => _list.Count;
}