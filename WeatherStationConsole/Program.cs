using WeatherStationClass.Classes;

// Initializing and using WeatherData and CurrentConditionsDisplay
WeatherData weatherData = WeatherData.GetInstance();
CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

// Simulate new weather measurements
weatherData.SetWeather(80, 65, 30.4f);
weatherData.SetWeather(82, 70, 29.2f);