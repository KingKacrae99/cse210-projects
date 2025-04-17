public class EternalGoal : Goal {

    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStatus()
    {
        return $"{_name} (Eternal)";
    }

    public override string Serialize()
    {
        return $"Eternal|{_name}|{_points}";
    }
}