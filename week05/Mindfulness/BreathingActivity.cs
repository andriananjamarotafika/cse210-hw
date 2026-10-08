public class BreathingActivity : Activity
{
    private static int _iteration = 0;
    public BreathingActivity(string name, string description) : base(name, description)
    {
        _iteration++;
    }

    public void Run()
    {
        LoadStart();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }

    public static int GetBreatheIteration()
    {
        return _iteration;
    }
}