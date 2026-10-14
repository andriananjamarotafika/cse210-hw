public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
        return $"{GetGoalName()} ({GetGoalDescription()})";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulation! You have earned {GetGoalPoints()} points.");
    }


}