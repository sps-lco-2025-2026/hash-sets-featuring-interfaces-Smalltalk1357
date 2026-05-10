namespace MyHashSetTests;
using MyHashSet;

[TestClass]
public sealed class TestStudent
{
    [TestMethod]
    public void TestToString()
    {
        SPSStudent student = new("John", 12, "CAH");
        Assert.AreEqual("John: Y12-CAH", student.ToString());
    }
}