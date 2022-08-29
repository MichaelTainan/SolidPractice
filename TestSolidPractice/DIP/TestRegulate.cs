using System;
using SolidPractice.DIP;

namespace TestSolidPractice.DIP;

[TestFixture]
public class TestRegulate
{
    private Regulate regulate;

    [Test]
    public void TestEngage()
    {
        regulate = new Regulate();
        regulate.Engage();
        Assert.AreEqual()
    }
}

