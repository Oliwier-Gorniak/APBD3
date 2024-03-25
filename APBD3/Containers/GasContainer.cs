using APBD3.Interfaces;

namespace APBD3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }
    public bool IsHazardous { get; set; }

    public GasContainer(double loadMass, double height, double selfWeight, double depth, double maxLoadCapacity, double pressure, bool isHazardous)
    {
        LoadMass = loadMass;
        Height = height;
        SelfWeight = selfWeight;
        Depth = depth;
        MaxLoadCapacity = maxLoadCapacity;
        SerialNumber = SerialNumberGenerator.GenerateSerialNumber("G");
        Pressure = pressure;
        IsHazardous = isHazardous;
    }

    public override void Load(double mass)
    {
        // Implementacja metody Load
    }

    public override void Unload()
    {
        // Implementacja metody Unload
    }

    public void NotifyHazard(string message)
    {
        // Implementacja metody NotifyHazard
    }
}
