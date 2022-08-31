using System.Threading;

namespace SolidPractice.ISP;

public class DoorTimerAdapter : TimerClient
{
    private Door timedDoor;

    public DoorTimerAdapter(Door theDoor)
    {
        timedDoor = theDoor;
    }

    public bool IsAlert()
    {
        return isAlert;
    }

    public void TimeOut()
    {
        timedDoor.DoorTimeOut(timeOutId);
    }
}
