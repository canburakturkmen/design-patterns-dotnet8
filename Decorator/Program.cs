using Decorator;

// Basic Coffee
ICoffee coffee = new BasicCoffee();
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost():0.00}");

// Add Milk
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost():0.00}");

// Add Sugar
coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost():0.00}");

// Add Cream
coffee = new CreamDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost():0.00}");