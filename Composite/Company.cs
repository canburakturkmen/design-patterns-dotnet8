namespace Composite;
using System;
using System.Collections.Generic;

// Component Interface
public interface IEmployee
{
    void ShowDetails();
}

// Leaf Class
public class Employee : IEmployee
{
    private readonly string _name;
    private readonly string _position;

    public Employee(string name, string position)
    {
        _name = name;
        _position = position;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{_position}: {_name}");
    }
}

// Composite Class
public class Manager : IEmployee
{
    private readonly string _name;
    private readonly string _position;
    private readonly List<IEmployee> _subordinates = new();

    public Manager(string name, string position)
    {
        _name = name;
        _position = position;
    }

    public void AddSubordinate(IEmployee employee)
    {
        _subordinates.Add(employee);
    }

    public void RemoveSubordinate(IEmployee employee)
    {
        _subordinates.Remove(employee);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{_position}: {_name}");
        Console.WriteLine("Subordinates:");
        foreach (var subordinate in _subordinates)
        {
            subordinate.ShowDetails();
        }
    }
}
