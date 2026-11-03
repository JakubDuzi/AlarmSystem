namespace Alarm;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        AlarmSystem alarm = new AlarmSystem();

        SecurityDisplay display = new SecurityDisplay();
        MobileApp mobile = new MobileApp();
        Logger logger = new Logger();

        alarm.Subscribe(display);
        alarm.Subscribe(mobile);
        alarm.Subscribe(logger);

        alarm.TriggerAlarm("učebna A202");
        Console.WriteLine();
        alarm.TriggerAlarm("serverovna");
        Console.WriteLine();
        alarm.TriggerAlarm("chodba B");
        Console.WriteLine();

        Console.WriteLine("Odhlašuji MobileApp...");
        alarm.Unsubscribe(mobile);
        Console.WriteLine();

        alarm.TriggerAlarm("vstupní hala");
        Console.WriteLine();

        logger.ShowHistory();
    }
}