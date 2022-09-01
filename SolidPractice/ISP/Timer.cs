using System;
using System.Collections;

namespace SolidPractice.ISP;

public class Timer
{
    private TimerClient myClient;
    private int myTimeout;

    public void Register(int timeout, TimerClient client)
    {
        myClient = client;
        myTimeout = timeout;
    }

    public void Check(int timeRange)
    {
        if (timeRange > myTimeout)
        {
            myClient.TimeOut();
        }
    }
}

