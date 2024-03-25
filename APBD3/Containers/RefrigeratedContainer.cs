namespace APBD3.Containers;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public override void Load(double mass)
    {
        // Implementacja metody Load
    }

    public override void Unload()
    {
        // Implementacja metody Unload
    }
}