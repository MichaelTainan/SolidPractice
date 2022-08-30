using System;
using System.Diagnostics.Metrics;
using SolidPractice.DIP;

namespace TestSolidPractice.DIP;

[TestFixture]
public class TestRegulate
{
    private Regulate regulate;
    private Heater furnace;
    private Thermometer ioChannelThermometer;

    [SetUp]
    public void SetUp()
    {
        regulate = new Regulate();
        furnace = new Furnace();
        ioChannelThermometer = new IOChannelThermometer();
    }


    [Test]
    public void TestHeaterHeating()
    {
        ioChannelThermometer.Write(20);
        regulate.RegulateHeater(ioChannelThermometer, furnace, 30, 70);
        Assert.AreEqual(true, furnace.GetHeating());
    }

    [Test]
    public void TestHeaterNotHeating()
    {
        ioChannelThermometer.Write(100);
        regulate.RegulateHeater(ioChannelThermometer, furnace,30,90);
        Assert.AreEqual(false, furnace.GetHeating());
    }
}

