namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class ForecastDisplay : IObserver, IDisplay
{
    private double temperature;
    private double pressure;
    private double humidity;

    /// <summary>
    /// Initializes a new instance of the ForecastDisplay class,
    /// subscribing it to receive updates from the specified weather data subject.
    /// </summary>
    /// <param name="weatherData">The weather data subject to subscribe to for updates.</param>
    public ForecastDisplay(ISubject weatherData)
    {
        weatherData.Subscribe(this);
    }

    /// <summary>
    /// Updates the forecast display with new data received from the weather data subject.
    /// Applies random variations to simulate changes in future weather conditions.
    /// </summary>
    /// <param name="temperature">The latest temperature reading from the subject.</param>
    /// <param name="humidity">The latest humidity percentage from the subject.</param>
    /// <param name="pressure">The latest atmospheric pressure reading from the subject.</param>
    public void Update(double temperature, double humidity, double pressure)
    {
        Random random = new Random();
        this.temperature = temperature + random.Next(1, 10);
        this.pressure = pressure + random.Next(1, 10);
        this.humidity = humidity + random.Next(1, 10);
        Display();
    }

    /// <summary>
    /// Displays the forecasted weather conditions.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"The weather forecasts are: {temperature}F degrees, {pressure}Pa pressure, and {humidity}% humidity");
    }
}
