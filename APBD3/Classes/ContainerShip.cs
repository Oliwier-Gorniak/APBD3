using APBD3.Containers;
using APBD3.Exceptions;

namespace APBD3.Classes;

public class ContainerShip
{
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainerCount { get; set; }
    public int MaxContainerWeight { get; set; }
    public double ContainerWeight { get; set; }

    public ContainerShip(double maxSpeed, int maxContainerCount, int maxContainerWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainerCount = maxContainerCount;
        MaxContainerWeight = maxContainerWeight;
    }

    public void LoadContainer(Container container)
    {
        if (ContainerWeight + container.LoadMass > MaxContainerWeight)
        {
            throw new OverfillException("The ship is overfilled. - too heavy weight");
        }

        if (Containers.Count + 1 > MaxContainerCount)
        {
            throw new OverfillException("The ship is overfilled. - too many containers");
        }

        Containers.Add(container);
        ContainerWeight += container.LoadMass;
    }
    
    public void LoadContainers(List<Container> containers)
    {
        foreach (var container in containers)
        {
            LoadContainer(container);
        }
    }
    
    public void UnloadContainer(string serialNumber)
    {
        if (Containers.Count == 0)
        {
            throw new InvalidOperationException("No containers to unload.");
        }
        if (Containers.Exists(c => c.SerialNumber == serialNumber) == false)
        {
            throw new InvalidOperationException($"No container found with serial number {serialNumber}.");
        }

        ContainerWeight -= Containers.Last().LoadMass;
        Containers.Remove(Containers.Last());
    }

    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        var containerToReplace = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);

        if (containerToReplace == null)
        {
            throw new InvalidOperationException($"No container found with serial number {serialNumber}.");
        }

        if (ContainerWeight - containerToReplace.LoadMass + newContainer.LoadMass > MaxContainerWeight)
        {
            throw new OverfillException("The ship is overfilled. - too heavy weight");
        }

        Containers.Remove(containerToReplace);
        Containers.Add(newContainer);
        ContainerWeight = ContainerWeight - containerToReplace.LoadMass + newContainer.LoadMass;
    }
    
    public void TransferContainer(string serialNumber, ContainerShip targetShip)
    {
        var containerToTransfer = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);

        if (containerToTransfer == null)
        {
            throw new InvalidOperationException($"No container found with serial number {serialNumber}.");
        }

        if (targetShip.ContainerWeight + containerToTransfer.LoadMass > targetShip.MaxContainerWeight)
        {
            throw new OverfillException("The target ship is overfilled. - too heavy weight");
        }

        Containers.Remove(containerToTransfer);
        targetShip.LoadContainer(containerToTransfer);
        ContainerWeight -= containerToTransfer.LoadMass;
    }
    
    public override string ToString()
    {
        var containerInfo = string.Join(", ", Containers.Select(c => c.ToString()));
        return $"Container Ship: Max Speed = {MaxSpeed}, Max Container Count = {MaxContainerCount}, Max Container Weight = {MaxContainerWeight}, Container Weight = {ContainerWeight}, Containers = [{containerInfo}]";
    }
}