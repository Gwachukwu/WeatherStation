namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;
using WeatherStationClass.Enums;

public class WeatherStation
{
    /// <summary>
    /// Creates and returns an IDisplay instance based on the specified display type.
    /// </summary>
    /// <param name="displayType">The type of display to create, as specified by the DisplayEnum.</param>
    /// <returns>An instance of IDisplay corresponding to the specified display type.</returns>
    /// <exception cref="ArgumentException">Thrown when an undefined displayType is passed to the method.</exception>
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
                throw new ArgumentException("Invalid Display Command", nameof(displayType));
        }
    }
}
