using WeatherStationClass.Classes;

using WeatherStationClass.interfaces;

// Initializing and using WeatherData and CurrentConditionsDisplay
WeatherData weatherData = WeatherData.GetInstance();
CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

// Simulate new weather measurements
weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);