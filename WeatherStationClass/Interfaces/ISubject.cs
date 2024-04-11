namespace WeatherStationClass.Interfaces;

/// <summary>
/// Defines the interface for a subject in the Observer design pattern.
/// This interface allows observers to subscribe or unsubscribe from the subject.
/// </summary>
public interface ISubject
{
    /// <summary>
    /// Subscribes an observer to receive updates. This method adds the observer to the subject's
    /// list of observers that need to be notified of changes.
    /// </summary>
    /// <param name="observer">The observer that wants to subscribe to notifications.</param>
    void Subscribe(IObserver observer);
    /// <summary>
    /// Unsubscribes an observer from receiving updates. This method removes the observer from
    /// the subject's list of observers
    /// </summary>
    /// <param name="observer">The observer that wants to unsubscribe from notifications.</param>
    void UnSubscribe(IObserver observer);
    /// <summary>
    /// Notifies all subscribed observers of a change in the subject's state.
    /// </summary>
    void Notify();
}
