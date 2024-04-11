namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public abstract class Decorator : IObserver, IDisplay
{
    private double temperature;
    private double humidity;
    private double pressure;

    /// <summary>
    /// Initializes a new instance of the Decorator class and subscribes it to the provided weather data subject.
    /// </summary>
    /// <param name="weatherData">The subject that provides updates on weather conditions.</param>
    public Decorator(ISubject weatherData)
    {
        weatherData.Subscribe(this);
    }

    /// <summary>
    /// Updates the internal state of the display with the latest weather data from the subject.
    /// This method is called whenever the subject notifies its observers of changes.
    /// </summary>
    /// <param name="temperature">The latest temperature reading in Fahrenheit.</param>
    /// <param name="humidity">The latest humidity percentage.</param>
    /// <param name="pressure">The latest atmospheric pressure in Pascals.</param>
    public void Update(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        Display();
    }

    /// <summary>
    /// Displays the current weather conditions. This method can be overridden by subclasses
    /// </summary>
    public virtual void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity and {pressure}Pa pressure");
    }
}
