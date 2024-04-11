using WeatherStationClass.Classes;
using WeatherStationClass.Interfaces;
using WeatherStationClass.Enums;

IDisplay currentConditionsDisplay = WeatherStation.CreateDisplay(DisplayEnum.CurrentConditionsDisplay);
IDisplay forecastDisplay = WeatherStation.CreateDisplay(DisplayEnum.ForecastDisplay);
IDisplay statisticsDisplay = WeatherStation.CreateDisplay(DisplayEnum.StatisticsDisplay);

WeatherData weatherData = WeatherData.GetInstance();
weatherData.SetWeather(72, 50, 29.92);