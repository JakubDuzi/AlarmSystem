namespace Alarm;

public class AlarmSystem
{
    private List<IObserver> observers = new();

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void Notify(string message)
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(message);
        }
    }

    public void TriggerAlarm(string location)
    {
        Notify($"Pohyb detekován: {location}");
    }
}