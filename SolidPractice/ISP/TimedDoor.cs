namespace SolidPractice.ISP;

public class TimedDoor : TimeDoor
{
    private bool isDoorOpen;
    private bool isAlert;
    public TimedDoor()
    {
    }

    public bool IsAlert()
    {
        return isAlert;
    }

    public void Unlock()
    {
        isDoorOpen = true;
    }

    public void Lock()
    {
        isDoorOpen = false;
        isAlert = false;
    }

    public bool IsDoorOpen()
    {
        return isDoorOpen;
    }

    public void TimeOut()
    {
        isAlert=true;
    }

}

public interface TimeDoor : Door, TimerClient
{
}