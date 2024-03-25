using APBD3.Containers;

namespace APBD3.Classes;

public class ContainerShip
{
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainerCount { get; set; }
    public int MaxContainerWeight { get; set; }

    public ContainerShip(double maxSpeed, int maxContainerCount, int maxContainerWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainerCount = maxContainerCount;
        MaxContainerWeight = maxContainerWeight;
    }

    public void LoadContainer(Container container)
    {
        // Implementacja metody LoadContainer
    }

    public void UnloadContainer(string serialNumber)
    {
        // Implementacja metody UnloadContainer
    }

    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        // Implementacja metody ReplaceContainer
    }
}