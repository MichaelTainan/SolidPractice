using System;
using SolidPractice.ISP;

namespace TestSolidPractice.ISP;

[TestFixture]
public class TestTimedDoorByAdapter
{
    private Door timedDoor;
    private SolidPractice.ISP.Timer timer;
    public TestTimedDoorByAdapter()
    {
    }

    [Test]
    public void TestIsDoorOpen()
    {
        timedDoor = new TimedDoorByAdapter();
        timedDoor.Unlock();
        Assert.IsTrue(timedDoor.IsDoorOpen());
    }

    [Test]
    public void TestAlert()
    {
        timedDoor = new TimedDoorByAdapter();
        timer = new SolidPractice.ISP.Timer();
        timedDoor.Unlock();
        timer.Register(15, timedDoor);
        Assert.IsTrue(timedDoor.IsAlert());
    }
}

