namespace SolidPractice.ISP;

public class DoorTimerAdapter : TimerClient
{
    private TimedDoorForAdapter timedDoorForAdapter;
    private bool isDoorOpen;
    private bool isAlert;
    public DoorTimerAdapter(TimedDoorForAdapter theDoor)
    {
        timedDoorForAdapter = theDoor;
    }

    public bool IsAlert()
    {
        return isAlert;
    }

    //public void Unlock()
    //{
    //    isDoorOpen = true;
    //}

    //public void Lock()
    //{
    //    isDoorOpen = false;
    //    isAlert = false;
    //}

    //public bool IsDoorOpen()
    //{
    //    return isDoorOpen;
    //}

    public void TimeOut()
    {
        isAlert=true;
    }

    public virtual void TimeOut(int timeOutId)
    {
        timedDoorForAdapter.DoorTimeOut(timeOutId);
    }

}

public interface TimedDoorForAdapter : Door
{
    void DoorTimeOut(int timeOutId);
}
