using APBD3.Classes;
using APBD3.Containers;

LiquidContainer liquidContainer = new LiquidContainer(390, 20, 20, 20, 400, false);
RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(200, 20, 20, 20, 400, "Fish", 2);
GasContainer gasContainer = new GasContainer(200, 20, 20, 20, 400, 2, true, 200);
Console.WriteLine(liquidContainer.SerialNumber);
Console.WriteLine(refrigeratedContainer.SerialNumber);
Console.WriteLine(gasContainer.SerialNumber);
refrigeratedContainer.Load(30);
Console.WriteLine(refrigeratedContainer.LoadMass);
ContainerShip containerShip = new ContainerShip(40, 20, 10000);
containerShip.LoadContainer(liquidContainer);
containerShip.ReplaceContainer("KON-L-1", refrigeratedContainer);
Console.WriteLine(containerShip.Containers[0]);
containerShip.UnloadContainer("KON-C-1");
