using APBD3.Exceptions;

namespace APBD3.Containers;

public class RefrigeratedContainer : Container
{
    private string ProductType { get; set; }
    private double Temperature { get; set; }

    public RefrigeratedContainer(double loadMass, double height, double selfWeight, double depth, double maxLoadCapacity, string productType, double temperature) : base(loadMass, height, selfWeight, depth, maxLoadCapacity)
    {
        if (loadMass > maxLoadCapacity)
        {
            throw new OverfillException("Load too high for provided max load capacity.");
        }
        SerialNumber = SerialNumberGenerator.GenerateSerialNumber("C");
        ProductType = productType;
        Temperature = temperature;
    }

    public override void Load(double mass)
    {
        if (LoadMass + mass > MaxLoadCapacity)
        {
            throw new OverfillException("The container is overfilled.");
        }
        
        LoadMass += mass;
    }

    public override void Unload()
    {
        LoadMass = 0;
    }
    
    public override string ToString()
    {
        return $"Container: Serial Number = {SerialNumber}, Load Mass = {LoadMass}, Height = {Height}, Self Weight = {SelfWeight}, Depth = {Depth}, Max Load Capacity = {MaxLoadCapacity}, Product Type = {ProductType}, Temperature = {Temperature}";
    }
}