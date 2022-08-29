namespace SolidPractice.DIP;

/// <summary>
/// The Button must depends on Interface(SwitchableDevice), not depend on Object(Lamp)
/// </summary>
public class Button
{
    //private Lamp lamp;  // depend on lamp.
    //public Button()
    //{
    //    lamp = new Lamp();
    //}
    private SwitchableDevice switchableDevice;
    public Button(SwitchableDevice switchableDevice)
    {
        this.switchableDevice = switchableDevice;
    }

    //public bool CheckLampResult()
    //{
    //    return lamp.Light;
    //}

    public void Poll()
    {
        if (switchableDevice.status() == false)
            switchableDevice.TurnOn();
        else
            switchableDevice.TurnOff();
    }

    public bool SwitchableDevice()
    {
        return switchableDevice.status();
    }
}