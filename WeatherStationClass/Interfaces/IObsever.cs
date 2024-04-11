namespace WeatherStationClass.Interfaces;

// IObserver interface
public interface IObserver
{
    void Update(double temperature, double humidity, double pressure);
}