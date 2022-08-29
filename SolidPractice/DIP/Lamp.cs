using System;
namespace SolidPractice.DIP;

public class Lamp: SwitchableDevice
{
    private bool light;
    public Lamp()
    {
        light = false;
    }

    public bool Light
    {
        get { return light; }
        //set { light = value; }
    }

    public void TurnOn()
    {
        light = true;
    }

    public void TurnOff()
    {
        light = false;
    }

    public bool status()
    {
        return light;
    }
}

