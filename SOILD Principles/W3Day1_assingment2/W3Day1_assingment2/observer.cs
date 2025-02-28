using System;
using System.Collections.Generic;

public interface observer1
{
    void Update(float temperature, float humidity);
}

public interface weather_sta
{
    void RegisterObserver(observer1 observer);
    void RemoveObserver(observer1 observer);
    void NotifyObservers();
}

public class WeatherStation : weather_sta
{
    private List<observer1> observers = new List<observer1>();
    private float temperature;
    private float humidity;

    public void RegisterObserver(observer1 observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(observer1 observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity);
        }
    }

    public void SetWeatherData(float temperature, float humidity)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        NotifyObservers();
    }
}


public class WeatherDisplay : observer1
{
    private string displayName;

    public WeatherDisplay(string name)
    {
        displayName = name;
    }

    public void Update(float temperature, float humidity)
    {
        Console.WriteLine($"{displayName} - Updated Weather Data: Temperature = {temperature}°C, Humidity = {humidity}%");
    }
}

class observer
{
    static void Main()
    {
        WeatherStation weatherStation = new WeatherStation();

        WeatherDisplay display1 = new WeatherDisplay("Display 1");
        WeatherDisplay display2 = new WeatherDisplay("Display 2");

        weatherStation.RegisterObserver(display1);
        weatherStation.RegisterObserver(display2);

        Console.WriteLine("Setting weather data...");
        weatherStation.SetWeatherData(25.0f, 60.0f);

        Console.WriteLine("\nRemoving Display 1 and updating weather...");
        weatherStation.RemoveObserver(display1);
        weatherStation.SetWeatherData(28.5f, 65.0f);
    }
}
