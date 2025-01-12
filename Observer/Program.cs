using Observer;

var weatherStation = new WeatherStation();

// Observers (Devices)
var display1 = new TemperatureDisplay("Display 1");
var display2 = new TemperatureDisplay("Display 2");
var logger = new TemperatureLogger();

// Attach observers to the subject
weatherStation.AddObserver(display1);
weatherStation.AddObserver(display2);
weatherStation.AddObserver(logger);

// Change the temperature, notify observers
weatherStation.SetTemperature(22.5f);

Console.WriteLine();

// Remove an observer
weatherStation.RemoveObserver(display1);

// Change the temperature again, notify remaining observers
weatherStation.SetTemperature(25.0f);