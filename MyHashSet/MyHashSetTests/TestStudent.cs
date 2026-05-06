namespace MyHashSetTests;
using MyHashSet;

[TestClass]
public sealed class TestStudent
{
    [TestMethod]
    public void TestToString()
    {
        SPSStudent student = new("John", 12, "CAH");
        Assert.AreEqual("John: Y12, CAH", student.ToString());
    }
    
    [TestMethod]
    public void TestHashCode()
    {
        SPSStudent student = new("John", 12, "CAH");
        Assert.AreEqual(HashCode.Combine("John", 12, "CAH"), student.GetHashCode());
    }
}