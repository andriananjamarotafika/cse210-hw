public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private static int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        int options = 0;
        do
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("""
        Menu Options :
            1. Create a New Goal
            2. List Goals
            3. Save Goal
            4. Load Goals
            5. Record Event
            6. Quit
        """);
            Console.Write("Select a choice frome the menu : ");
            options = int.Parse(Console.ReadLine());
            if (options == 1)
            {
                ListGoalNames();
                CreateGoal();
            }
            else if (options == 2)
            {
                ListGoalDetails();
            }
            else if (options == 3)
            {
                SaveGoals();
            }
            else if (options == 4)
            {
                LoadGoals();
            }
            else if (options == 5)
            {
                Goal goalEvent = RecordEvent();
                goalEvent.RecordEvent();
                _score += int.Parse(goalEvent.GetGoalPoints());
                Console.WriteLine($"You now have {_score} points.");
            }
            else if (options == 6)
            {
                Console.WriteLine("Thank you !");
                break;
            }
            else
            {
                Console.WriteLine("Invalid number .");
            }

        } while (options != 6);
    }

    public static int GetScore()
    {
        return _score;
    }

    public static void SetScore(int score)
    {
        _score = score;
    }

    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {
        Console.WriteLine("""
        The types of Goals are :
        1. Simple Goal
        2. Eternal Goal
        3. checklist Goal
        """);
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int index = 0;
        foreach (Goal goal in goals)
        {
            string sign = "";
            ++index;
            if (goal.IsComplete())
            {
                sign = "X";
            }
            Console.WriteLine($"{index}. [{sign}] {goal.GetStringRepresentation()}");
        }

    }

    public void CreateGoal()
    {
        Console.Write("Which type of goal would you like to create? ");
        int numGoal = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (numGoal == 1)
        {
            SimpleGoal goal = new SimpleGoal(shortName, description, points);
            goals.Add(goal);
        }
        else if (numGoal == 2)
        {
            EternalGoal goal = new EternalGoal(shortName, description, points);
            goals.Add(goal);
        }
        else if (numGoal == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(shortName, description, points, target, bonus);
            goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }

    public Goal RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int index = 0;
        foreach (Goal goal in goals)
        {
            ++index;
            Console.WriteLine($"{index}. {goal.GetGoalName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        return goals[goalNumber];
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename of the goal file : ");
        string filename = Console.ReadLine();
        string fullPath = Path.GetFullPath(filename);

        using (StreamWriter outputFile = new StreamWriter(fullPath))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in goals)
            {
                Type type = goal.GetType();
                if (type.ToString() == "SimpleGoal")
                {
                    outputFile.WriteLine($"{type.Name},{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()},{goal.IsComplete()}");
                }
                else if (type.ToString() == "EternalGoal")
                {
                    outputFile.WriteLine($"{type.Name},{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()}");
                }
                else if (type.ToString() == "ChecklistGoal")
                {
                    outputFile.WriteLine($"{type.Name},{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetGoalPoints()},{goal.GetDetailString()}");
                }
            }

        }
        Console.WriteLine($"Goals saved to: {fullPath}");

    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                    goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                    goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                    goals.Add(checklistGoal);
                    break;
                default:
                    _score = int.Parse(parts[0]);
                    break;
            }
        }

    }

}