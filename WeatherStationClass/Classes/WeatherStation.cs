namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;
using WeatherStationClass.Enums;

public class WeatherStation
{
    public static IDisplay CreateDisplay(DisplayEnum displayType)
    {
        WeatherData weatherData = WeatherData.GetInstance();
        switch (displayType)
        {
            case DisplayEnum.CurrentConditionsDisplay:
                return new CurrentConditionsDisplay(weatherData);
            case DisplayEnum.ForecastDisplay:
                return new ForecastDisplay(weatherData);
            case DisplayEnum.StatisticsDisplay:
                return new StatisticsDisplay(weatherData);
            default:
                throw new ArgumentException("Invalid Display Command");
        }
    }
}
