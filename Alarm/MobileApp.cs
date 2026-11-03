namespace Alarm;

public class MobileApp : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"MOBIL: Nové upozornění - {message}");
    }
}