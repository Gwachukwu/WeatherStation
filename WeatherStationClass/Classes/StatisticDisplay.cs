namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class StatisticsDisplay : IObserver, IDisplay
{
    private double temperature;
    private double humidity;

    public StatisticsDisplay(ISubject weatherData)
    {
        weatherData.Subscribe(this);
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = temperature;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"The temperature statistics are: Average temperature = 70F, Max 89F, Min 45F");
    }
}
