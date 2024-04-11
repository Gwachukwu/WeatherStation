namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

public class WeatherStation
{
    public static IDisplay CreateDisplay(ISubject weatherData)
    {
        switch (weatherData)
        {
            case CurrentConditionsDisplay:
                return new CurrentConditionsDisplay(weatherData);
            case ForecastDisplay:
                return new ForecastDisplay(weatherData);
            case StatisticsDisplay:
                return new StatisticsDisplay(weatherData);
            default:
                throw new ArgumentException("Invalid Display Command");
        }
    }

    // Add methods to create other types of displays like StatisticsDisplay, ForecastDisplay, etc.
}
