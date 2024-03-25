using APBD3.Exceptions;

namespace APBD3.Containers;

public class LiquidContainer : Container
{
    public bool IsHazardous { get; set; }

    public LiquidContainer(double loadMass, double height, double selfWeight, double depth, double maxLoadCapacity, bool isHazardous) : base(loadMass, height, selfWeight, depth, maxLoadCapacity)
    {
        if (loadMass > maxLoadCapacity)
        {
            throw new OverfillException("Load too high for provided max load capacity.");
        }
        if (isHazardous && loadMass > maxLoadCapacity * 0.5)
        {
            NotifyHazard("You are trying to load too much dangerous liquid!");
        }
        if (loadMass > maxLoadCapacity * 0.9)
        {
            NotifyHazard("You are trying to load too much liquid!");
        }
        SerialNumber = SerialNumberGenerator.GenerateSerialNumber("L");
        IsHazardous = isHazardous;
    }

    public override void Load(double mass)
    {
        if (LoadMass + mass > MaxLoadCapacity)
        {
            throw new OverfillException("The container is overfilled.");
        }
        if (IsHazardous && LoadMass + mass > MaxLoadCapacity * 0.5)
        {
            NotifyHazard("You are trying to load too much dangerous liquid!");
        }
        if (LoadMass + mass > MaxLoadCapacity * 0.9)
        {
            NotifyHazard("You are trying to load too much liquid!");
        }
        
        LoadMass += mass;
    }

    public override void Unload()
    {
        LoadMass = 0;
    }
    
    public void NotifyHazard(string message)
    {
        Console.WriteLine(message);
    }
}
