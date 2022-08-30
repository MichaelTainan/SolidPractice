using System;
namespace SolidPractice.DIP;

public interface Heater
{
    public void Disengage();
    public void Engage();
    public bool GetHeating();
}

