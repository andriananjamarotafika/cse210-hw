public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetGoalName()} ({GetGoalDescription()}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override bool IsComplete()
    {

        if (_amountCompleted < _target)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public override void RecordEvent()
    {

        if (_amountCompleted == _target)
        {
            SetGoalPoints(GetGoalPoints() + _bonus);
            Console.WriteLine($"Congratulation! You have earned {GetGoalPoints()} points.");
        }
        else if (_amountCompleted > _target)
        {
            Console.WriteLine("This goal is already Done, Create a new Goal");
        }
        else
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulation! You have earned {GetGoalPoints()} points.");
        }

    }

    public override string GetDetailString()
    {
        return $"{_target},{_bonus},{_amountCompleted}";
    }

}