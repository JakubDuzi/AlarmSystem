namespace Alarm;

public class SecurityDisplay : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"MONITOR: {message}");
    }
}