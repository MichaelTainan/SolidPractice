using System;
namespace SolidPractice.DIP;

public class IOChannelThermometer : Thermometer
{
    private double temperature;

    public double Read()
    {
        return temperature;
    }

    public void Write(double temp)
    {
        temperature = temp;
    }
}
