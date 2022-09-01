using System;
namespace SolidPractice.ISP;

public class TimedDoorAdaptee : Door
{
    private bool isDoorOpen;

    public TimedDoorAdaptee()
    {
    }

    public void Unlock()
    {
        isDoorOpen = true;
    }

    public void Lock()
    {
        isDoorOpen = false;
        //isAlert = false;
    }

    public bool IsDoorOpen()
    {
        return isDoorOpen;
    }

    //internal void DoorTimeOut(int timeOutId)
    //{
    //    throw new NotImplementedException();
    //}
}

