namespace MyHashSetTests;
using MyHashSet;

[TestClass]
public class TestHashSet
{
    [TestMethod]
    public void TestConstructor()
    {
        MyHashSet<int> hashSet = new MyHashSet<int>(3);
        Assert.AreEqual(",,", hashSet.ToString());
    }
    [TestMethod]
    public void TestAdd()
    {
        MyHashSet<int> hashSet = new MyHashSet<int>(3);
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        
        Assert.AreEqual(3, hashSet.Count);
        Assert.IsTrue(hashSet.Contains(1));
        Assert.IsTrue(hashSet.Contains(2));
        Assert.IsTrue(hashSet.Contains(3));
        Assert.IsFalse(hashSet.Contains(4));
    }

    [TestMethod]
    public void TestRemove()
    {
        MyHashSet<int> hashSet = new MyHashSet<int>(3);
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
    }
}