using System;
namespace SolidPractice.DIP;

public class Furnace : Heater
{
    private bool heating;
    public bool Heating
    {
        get { return heating; }
        set { heating = value; }
    }

    public void Disengage()
    {
        heating = false;
    }

    public void Engage()
    {
        heating = true;
    }

    public bool GetHeating()
    {
        return heating;
    }
}

