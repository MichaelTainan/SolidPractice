using System;
using SolidPractice.ISP;

namespace TestSolidPractice.ISP;

[TestFixture]
public class TestTimedDoorByAdapter
{
    private Door timedDoor;
    private TimerClient doorTimerAdapter;
    private SolidPractice.ISP.Timer timer;
    public TestTimedDoorByAdapter()
    {
    }

    [Test]
    public void TestIsDoorOpen()
    {
        timedDoor = new TimedDoorAdaptee();
        timedDoor.Unlock();
        Assert.IsTrue(timedDoor.IsDoorOpen());
    }

    [Test]
    public void TestAlert()
    {
        timedDoor = new TimedDoorAdaptee();
        doorTimerAdapter = new DoorTimerAdapter(timedDoor);
        timer = new SolidPractice.ISP.Timer();
        timedDoor.Unlock();
        timer.Register(10, doorTimerAdapter);
        timer.Check(15);
        Assert.IsTrue(doorTimerAdapter.IsAlert());
    }
}

