namespace WeatherStationClass.Classes;

using WeatherStationClass.Interfaces;

// public class DisplayDecorator : IDisplay
// {
//     private IDisplay wrappedDisplay;

//     public DisplayDecorator(IDisplay display)
//     {
//         this.wrappedDisplay = display;
//     }

//     public void Display()
//     {
//         wrappedDisplay.Display();
//         Console.WriteLine($"Updated At: {DateTime.Now}");
//     }
// }

public class CurrentConditionsDisplay : IObserver, IDisplay
{
    private double temperature;
    private double humidity;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        weatherData.Subscribe(this);
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        Console.WriteLine($"Updated At: {DateTime.Now}");
    }
}



