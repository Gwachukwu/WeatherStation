namespace WeatherStationClass.Classes;

using WeatherStationClass.interfaces;

public class CurrentConditionsDisplay : IObserver, IDisplay
{
    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }
}

public class DisplayDecorator : IDisplay
{
    private IDisplay wrappedDisplay;

    public DisplayDecorator(IDisplay display)
    {
        this.wrappedDisplay = display;
    }

    public void Display()
    {
        wrappedDisplay.Display();
        Console.WriteLine($"Updated At: {DateTime.Now}");
    }
}

