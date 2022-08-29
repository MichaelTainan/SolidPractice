namespace SolidPractice.DIP;

/// <summary>
/// The Button must depends on Interface(ButtonServer), can't depend on Object(Lamp)
/// </summary>
public class Button
{
    //private Lamp lamp;  // depend on lamp.
    //public Button()
    //{
    //    lamp = new Lamp();
    //}
    private ButtonServer buttonServer;
    public Button(ButtonServer buttonServer)
    {
        this.buttonServer = buttonServer;
    }

    //public bool CheckLampResult()
    //{
    //    return lamp.Light;
    //}

    public void Poll()
    {
        if (buttonServer.status() == false)
            buttonServer.TurnOn();
        else
            buttonServer.TurnOff();
    }

    public bool ButtonServerStatus()
    {
        return buttonServer.status();
    }
}