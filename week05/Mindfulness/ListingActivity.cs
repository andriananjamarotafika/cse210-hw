public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private static int _iteration = 0;

    private List<string> userPrompt = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _iteration++;
    }
    public void Run()
    {
        LoadStart();
        Console.WriteLine("List as many responses you can to the following prompts:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userPrompt.Add(Console.ReadLine());
            _count++;
        }
        Console.WriteLine($"You Listed {_count} items");
        Thread.Sleep(3000);
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count)]} --- ");
    }

    public List<string> GetListFromUser()
    {
        return userPrompt;
    }

    public static int GetListIteration()
    {
        return _iteration;
    }
}