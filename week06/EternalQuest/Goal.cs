public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();

    public string GetGoalName()
    {
        return _shortName;
    }

    public void SetGoalName(string name)
    {
        _shortName = name;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public void SetGoalDescription(string description)
    {
        _description = description;
    }

    public string GetGoalPoints()
    {
        return _points;
    }

    public void SetGoalPoints(string points)
    {
        _points = points;
    }
}