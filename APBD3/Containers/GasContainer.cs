using APBD3.Exceptions;
using APBD3.Interfaces;

namespace APBD3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double Pressure { get; set; }
    private bool IsHazardous { get; set; }
    private double HazardousLoad { get; set; }

    public GasContainer(double loadMass, double height, double selfWeight, double depth, double maxLoadCapacity, double pressure, bool isHazardous, double hazardousLoad) : base(loadMass, height, selfWeight, depth, maxLoadCapacity)
    {
        if (loadMass > maxLoadCapacity)
        {
            throw new OverfillException("Load too high for provided max load capacity.");
        }
        SerialNumber = SerialNumberGenerator.GenerateSerialNumber("G");
        Pressure = pressure;
        IsHazardous = isHazardous;
        HazardousLoad = hazardousLoad;
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
        LoadMass = LoadMass * 0.05;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine(message);
    }
    
    public override string ToString()
    {
        return
            $"Container: Serial Number = {SerialNumber}, Load Mass = {LoadMass}, Height = {Height}, Self Weight = {SelfWeight}, Depth = {Depth}, Max Load Capacity = {MaxLoadCapacity}, Pressure = {Pressure}, Is Hazardous = {IsHazardous}, Hazardous Load = {HazardousLoad}";
    }
}
