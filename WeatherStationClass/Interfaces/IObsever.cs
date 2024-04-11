namespace WeatherStationClass.Interfaces;

public interface IObserver
{
    /// <summary>
    /// Updates the observer with the latest data from the subject it is observing.
    /// This method is called whenever the subject's state changes.
    /// </summary>
    /// <param name="temperature">The latest temperature reading from the subject.</param>
    /// <param name="humidity">The latest humidity reading from the subject.</param>
    /// <param name="pressure">The latest atmospheric pressure reading from the subject.</param>
    void Update(double temperature, double humidity, double pressure);
}