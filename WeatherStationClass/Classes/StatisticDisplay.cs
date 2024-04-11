namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class StatisticsDisplay : IObserver, IDisplay
{
    /// <summary>
    /// Initializes a new instance of the StatisticsDisplay class,
    /// subscribing it to receive updates from the specified weather data subject.
    /// </summary>
    /// <param name="weatherData">The weather data subject to subscribe to for updates.</param>
    public StatisticsDisplay(ISubject weatherData)
    {
        weatherData.Subscribe(this);
    }

    /// <summary>
    /// Updates the display's data storage with the latest temperature and humidity readings.
    /// </summary>
    /// <param name="temperature">The latest temperature reading from the subject.</param>
    /// <param name="humidity">The latest humidity reading from the subject.</param>
    /// <param name="pressure">The latest atmospheric pressure reading from the subject, currently unused.</param>
    public void Update(double temperature, double humidity, double pressure)
    {
        Display();
    }

    /// <summary>
    /// Displays static weather statistics.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"The temperature statistics are: Average temperature = 67F, Max 89F, Min 45F");
    }
}
