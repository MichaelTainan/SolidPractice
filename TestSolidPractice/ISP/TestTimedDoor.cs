using System;
using SolidPractice.ISP;

namespace TestSolidPractice.ISP;

[TestFixture]
public class TestTimedDoor
{
    private TimeDoor timedDoor;
    private SolidPractice.ISP.Timer timer;
    public TestTimedDoor()
    {
    }

    [Test]
    public void TestIsDoorOpen()
    {
        timedDoor = new TimedDoor();
        timedDoor.Unlock();
        Assert.IsTrue(timedDoor.IsDoorOpen());
    }

    [Test]
    public void TestAlert()
    {
        timedDoor = new TimedDoor();
        timer = new SolidPractice.ISP.Timer();
        timedDoor.Unlock();
        timer.Register(15, timedDoor);
        Assert.IsTrue(timedDoor.IsAlert());
    }
}

