namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class ForecastDisplay : IObserver, IDisplay
{
    private double temperature;
    private double humidity;

    public ForecastDisplay(ISubject weatherData)
    {
        weatherData.Subscribe(this);
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        Random random = new Random();
        this.temperature += random.Next(1, 10);
        this.humidity += random.Next(1, 10);
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"The weather forcasts are: {temperature}F degrees and {humidity}% humidity");
    }
}
