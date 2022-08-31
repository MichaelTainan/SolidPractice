using System;
namespace SolidPractice.ISP;

public class Timer
{
    public Timer()
    {
    }

    public void Register(int timeout, TimerClient client)
    {
        if (timeout > 10)
        {
            client.TimeOut();
        }
    }
}

