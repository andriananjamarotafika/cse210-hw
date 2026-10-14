public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        SetIsComplete(true);
        Console.WriteLine($"Congratulation! You have earned {GetGoalPoints()} points.");
    }
    public override bool IsComplete()
    {
        return GetIsComplete();
    }
    public override string GetStringRepresentation()
    {
        return $"{GetGoalName()} ({GetGoalDescription()})";
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

}