namespace SolidPractice.DIP;

public class Motor : SwitchableDevice
{
    private bool power;
    public Motor()
    {
        power = false;
    }

    public bool status()
    {
        return power;
    }

    public void TurnOff()
    {
        power = false;
    }

    public void TurnOn()
    {
        power = true;
    }
}