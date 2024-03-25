namespace APBD3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }
    public bool IsHazardous { get; set; }

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
