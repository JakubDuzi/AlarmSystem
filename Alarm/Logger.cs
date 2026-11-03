namespace Alarm;

public class Logger : IObserver
{
    private List<string> messages = new();

    public void Update(string message)
    {
        string record = $"{DateTime.Now:HH:mm} - {message}";
        messages.Add(record);
        Console.WriteLine($"LOG: {record}");
    }

    public void ShowHistory()
    {
        Console.WriteLine("--- Historie událostí ---");

        foreach (string record in messages)
        {
            Console.WriteLine(record);
        }
    }
}