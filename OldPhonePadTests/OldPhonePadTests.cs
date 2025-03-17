using NUnit.Framework;

[TestFixture]
public class OldPhonePadTests
{
    [Test]
    public void TestHello()
    {
        Assert.That("HELLO", Is.EqualTo(OldPhonePad.Decode("4433555 555666#")));
    }

    [Test]
    public void TestE()
    {
        Assert.That("E", Is.EqualTo(OldPhonePad.Decode("33#")));
    }

    [Test]
    public void TestB()
    {
        Assert.That("BP", Is.EqualTo(OldPhonePad.Decode("227#")));
    }

    [Test]
    public void TestQuestionMarks()
    {
        Assert.That("TURNG", Is.EqualTo(OldPhonePad.Decode("8 88777444666*664#")));
    }
}
