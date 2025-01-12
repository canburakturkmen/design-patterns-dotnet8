namespace AbstractFactory;

// Product Interface
public interface ITransport
{
    void Deliver();
}

// Concrete Product: Truck
public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by Truck.");
    }
}

// Concrete Product: Ship
public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by Ship.");
    }
}

// Creator (Factory Method)
public abstract class Logistics
{
    // Factory Method
    public abstract ITransport CreateTransport();

    public void PlanDelivery()
    {
        var transport = CreateTransport();
        Console.WriteLine("Planning delivery...");
        transport.Deliver();
    }
}

// Concrete Creator: RoadLogistics
public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}

// Concrete Creator: SeaLogistics
public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
