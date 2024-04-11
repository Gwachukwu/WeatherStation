namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class WeatherData : ISubject
{
    private static WeatherData instance;
    IList<IObserver> subscribers = new List<IObserver>();
    private double temperature;
    private double humidity;
    private double pressure;

    // Constructor is private for Singleton
    private WeatherData()
    {
        subscribers = new List<IObserver>();
    }

    // Public method to get the instance
    public static WeatherData GetInstance()
    {
        if (instance == null)
        {
            instance = new WeatherData();
        }
        return instance;
    }

    public void Subscribe(IObserver subscriber)
    {
        if (!subscribers.Contains(subscriber))
        {
            subscribers.Add(subscriber);
        }
    }

    public void UnSubscribe(IObserver subscriber)
    {
        if (subscribers.Contains(subscriber))
        {
            subscribers.Remove(subscriber);
        }
    }

    public void Notify()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(temperature, humidity, pressure);
        }
    }

    public void SetWeather(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        Notify();
    }
}