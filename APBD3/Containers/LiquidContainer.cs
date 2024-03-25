namespace APBD3.Containers;

public class LiquidContainer : Container
{
    public bool IsHazardous { get; set; }

    public LiquidContainer(double loadMass, double height, double selfWeight, double depth, double maxLoadCapacity, bool isHazardous)
    {
        LoadMass = loadMass;
        Height = height;
        SelfWeight = selfWeight;
        Depth = depth;
        MaxLoadCapacity = maxLoadCapacity;
        SerialNumber = SerialNumberGenerator.GenerateSerialNumber("L");
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
}
