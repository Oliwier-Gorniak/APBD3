namespace APBD3.Containers;

public abstract class Container
{
    public double LoadMass { get; set; }
    public double Height { get; set; }
    public double SelfWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxLoadCapacity { get; set; }

    protected Container(double loadMass, double height, double selfWeight, double depth, double maxLoadCapacity)
    {
        LoadMass = loadMass;
        Height = height;
        SelfWeight = selfWeight;
        Depth = depth;
        MaxLoadCapacity = maxLoadCapacity;
    }

    public abstract void Load(double mass);
    public abstract void Unload();
}