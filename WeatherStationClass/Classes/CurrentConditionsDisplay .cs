namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class CurrentConditionsDisplay : Decorator
{
    /// <summary>
    /// Initializes a new instance of the CurrentConditionsDisplay class,
    /// </summary>
    /// <param name="weatherData">The weather data subject to subscribe to for updates.</param>
    public CurrentConditionsDisplay(ISubject weatherData) : base(weatherData)
    {
    }

    /// <summary>
    /// Displays the current weather conditions along with the current time.
    /// Overrides the Display method from the Decorator class to add timestamp information
    /// to the output.
    /// </summary>
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Time is: {DateTime.Now}");
    }
}
