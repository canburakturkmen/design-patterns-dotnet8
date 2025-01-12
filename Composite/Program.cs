using Composite;

// Leaf Employees
IEmployee developer1 = new Employee("Alice", "Developer");
IEmployee developer2 = new Employee("Bob", "Developer");
IEmployee tester = new Employee("Charlie", "Tester");

// Manager (Composite)
Manager devManager = new Manager("David", "Development Manager");
devManager.AddSubordinate(developer1);
devManager.AddSubordinate(developer2);

// General Manager (Composite)
Manager generalManager = new Manager("Eve", "General Manager");
generalManager.AddSubordinate(devManager);
generalManager.AddSubordinate(tester);

// Display hierarchy
Console.WriteLine("Company Hierarchy:");
generalManager.ShowDetails();