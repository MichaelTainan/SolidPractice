using System;
using SolidPractice.DIP;

namespace TestSolidPractice.DIP;

[TestFixture]
public class TestButton
{
    private SwitchableDevice lamp;
    private SwitchableDevice motor;
    private Button button;
    public TestButton()
    {
    }

    [Test]
    public void TestLampTunOn()
    {
        lamp = new Lamp();
        lamp.TurnOn();
        Assert.AreEqual(true, lamp.status());
    }

    [Test]
    public void TestLampTunOff()
    {
        lamp = new Lamp();
        lamp.TurnOff();
        Assert.AreEqual(false, lamp.status());
    }

    [Test]
    public void TestButtonPoll()
    {
        lamp = new Lamp();
        button = new Button(lamp);
        //lamp.TurnOff();
        button.Poll();
        button.Poll();
        //Assert.AreEqual(true, button.CheckLampResult());  //depend on lamp, DIP violation.
        Assert.AreEqual(false, button.SwitchableDevice());

    }

    [Test]
    public void TestAnotherButtonPoll()
    {
        motor = new Motor();
        button = new Button(motor);
        button.Poll();
        button.Poll();
        Assert.AreEqual(false, button.SwitchableDevice());

    }
}
