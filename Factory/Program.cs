using AbstractFactory;

Logistics logistics;

Console.WriteLine("Enter delivery method (road/sea):");
var input = Console.ReadLine()?.ToLower();

logistics = input switch
{
    "road" => new RoadLogistics(),
    "sea" => new SeaLogistics(),
    _ => throw new InvalidOperationException("Invalid transport type!")
};

logistics.PlanDelivery();