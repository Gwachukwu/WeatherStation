namespace WeatherStationClass.Classes;

using WeatherStationClass.interfaces;

public class WeatherStation
{
    public static IDisplay CreateCurrentConditionsDisplay(ISubject weatherData)
    {
        CurrentConditionsDisplay display = new CurrentConditionsDisplay(weatherData);
        return new DisplayDecorator(display);
    }

    // Add methods to create other types of displays like StatisticsDisplay, ForecastDisplay, etc.
}
