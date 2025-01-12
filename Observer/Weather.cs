namespace Observer;

using System;
using System.Collections.Generic;

// Observer Interface
public interface IObserver
{
    void Update(float temperature);
}

// Subject Interface
public interface IWeatherStation
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// Concrete Subject: Weather Station
public class WeatherStation : IWeatherStation
{
    private readonly List<IObserver> _observers = new();
    private float _temperature;

    public void SetTemperature(float temperature)
    {
        _temperature = temperature;
        NotifyObservers();
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }
}

// Concrete Observer: Temperature Display
public class TemperatureDisplay : IObserver
{
    private readonly string _name;

    public TemperatureDisplay(string name)
    {
        _name = name;
    }

    public void Update(float temperature)
    {
        Console.WriteLine($"{_name} - Temperature updated: {temperature}°C");
    }
}

// Concrete Observer: Temperature Logger
public class TemperatureLogger : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Logging temperature: {temperature}°C");
    }
}