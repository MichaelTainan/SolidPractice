using System;
namespace SolidPractice.DIP;

public interface Heater
{
    void Disengage();
    void Engage();
    bool GetHeating();
}

