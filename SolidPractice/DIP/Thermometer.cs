using System;
namespace SolidPractice.DIP;

public interface Thermometer
{
    public double Read();
    public void Write(double temp);
}
