namespace APBD3.Containers;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public RefrigeratedContainer(double loadMass, double height, double selfWeight, double depth, double maxLoadCapacity, string productType, double temperature)
    {
        LoadMass = loadMass;
        Height = height;
        SelfWeight = selfWeight;
        Depth = depth;
        MaxLoadCapacity = maxLoadCapacity;
        SerialNumber = SerialNumberGenerator.GenerateSerialNumber("L");
        ProductType = productType;
        Temperature = temperature;
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