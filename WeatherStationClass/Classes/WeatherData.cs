namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class WeatherData : ISubject
{
    private static WeatherData? instance;
    private IList<IObserver> obserevers;
    private double temperature;
    private double humidity;
    private double pressure;

    /// <summary>
    /// Private constructor to prevent instantiation outside of the Singleton pattern. Initializes the
    /// list of obserevers.
    /// </summary>
    private WeatherData()
    {
        obserevers = new List<IObserver>();
    }

    /// <summary>
    /// Provides access to the singleton instance of the WeatherData class. If the instance does not exist,
    /// it is created.
    /// </summary>
    /// <returns>The singleton instance of the WeatherData class.</returns>
    public static WeatherData GetInstance()
    {
        if (instance == null)
        {
            instance = new WeatherData();
        }
        return instance;
    }

    /// <summary>
    /// Subscribes an observer to receive updates. Observers are added to a list and notified
    /// whenever the weather data changes.
    /// </summary>
    /// <param name="obserever">The observer to subscribe.</param>
    public void Subscribe(IObserver obserever)
    {
        if (!obserevers.Contains(obserever))
        {
            obserevers.Add(obserever);
        }
    }

    /// <summary>
    /// Unsubscribes an observer from receiving updates. If the observer is in the list of obserevers,
    /// it is removed.
    /// </summary>
    /// <param name="obserever">The observer to unsubscribe.</param>
    public void UnSubscribe(IObserver obserever)
    {
        if (obserevers.Contains(obserever))
        {
            obserevers.Remove(obserever);
        }
    }

    /// <summary>
    /// Notifies all subscribed observers of the current weather data. This method is called
    /// whenever the weather data is updated.
    /// </summary>
    public void Notify()
    {
        foreach (var obserever in obserevers)
        {
            obserever.Update(temperature, humidity, pressure);
        }
    }

    /// <summary>
    /// Updates the weather data and notifies all subscribed observers.
    /// </summary>
    /// <param name="temperature">The new temperature to set.</param>
    /// <param name="humidity">The new humidity to set.</param>
    /// <param name="pressure">The new pressure to set.</param>
    public void SetWeather(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        Notify();
    }
}
