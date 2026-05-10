namespace MyHashSetTests;
using MyHashSet;

[TestClass]
public class TestHashSet
{
    [TestMethod]
    public void TestConstructor()
    {
        MyHashSet<int> hashSet = new MyHashSet<int>(3);
        Assert.AreEqual("", hashSet.ToString());
    }
    [TestMethod]
    public void TestAdd()
    {
        MyHashSet<int> hashSet = new MyHashSet<int>(3);
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        
        Assert.IsTrue(hashSet.Contains(1));
        Assert.IsTrue(hashSet.Contains(2));
        Assert.IsTrue(hashSet.Contains(3));
    }

    [TestMethod]
    public void TestRemove()
    {
        MyHashSet<int> hashSet = new MyHashSet<int>(3);
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        
        hashSet.Remove(1);
        Assert.IsTrue(hashSet.Contains(2));
        Assert.IsTrue(hashSet.Contains(3));
        Assert.IsFalse(hashSet.Contains(1));
    }
    
    // now using the student class to test hashset
    [TestMethod]
    public void TestAddStudent()
    {
        MyHashSet<SPSStudent> hashSet = new MyHashSet<SPSStudent>(3);
        hashSet.Add(new SPSStudent("Alex", 12, "CAH"));
        hashSet.Add(new SPSStudent("Ben", 13, "CAH"));
        hashSet.Add(new SPSStudent("Charlie", 12, "CAH"));

        try
        {
            hashSet.Add(new SPSStudent("Dan", 13, "CAH"));
            Assert.Fail();
        }
        catch (Exception e)
        {
            Assert.AreEqual("Hashset is full", e.Message);
        }
    }

    [TestMethod]
    public void TestDuplicateStudent()
    {
        MyHashSet<SPSStudent> hashSet = new MyHashSet<SPSStudent>(10);
        hashSet.Add(new SPSStudent("Alex", 12, "CAH"));
        hashSet.Add(new SPSStudent("Ben", 13, "CAH"));
        hashSet.Add(new SPSStudent("Charlie", 12, "CAH"));
        
        hashSet.Add(new SPSStudent("Alex", 12, "CAH"));
        Assert.AreEqual(3, hashSet.Count);
    }
}