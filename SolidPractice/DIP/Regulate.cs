using System.Diagnostics.Metrics;

namespace SolidPractice.DIP;

/// <summary>
/// Regulate function depend on interface Thermometer, Heater
/// </summary>
public class Regulate
{
    public Regulate()
    {
    }

public void RegulateHeater(Thermometer t, Heater h, double minTemp, double maxTemp)
    {
        if (t.Read() < minTemp)
            h.Engage();
        if (t.Read() > maxTemp)
            h.Disengage();

    }
}