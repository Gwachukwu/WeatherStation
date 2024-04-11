namespace WeatherStationClass.Classes;

using WeatherStationClass.interfaces;

// IObserver interface
public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);
}

// ISubject interface
public interface ISubject
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

public class WeatherData : ISubject
{
    private static WeatherData instance;
    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    // Constructor is private for Singleton
    private WeatherData()
    {
        observers = new List<IObserver>();
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

    public void RegisterObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}