using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2026, 10, 14), 30, 4.8),
            new Cycling(new DateTime(2026, 09, 1), 45, 20.0),
            new Swimming(new DateTime(2026, 07, 20), 30, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}