public class SimpleGoal : Goal{

    private bool _completed;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _completed = false;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _completed ? $"[X] {_name}" : $"[ ] {_name}";
    }

    public override string Serialize()
    {
        return $"Simple|{_name}|{_points}|{_completed}";
    }

    // Additional constructor for deserialization
    public SimpleGoal(string name, int points, bool completed) : base(name, points)
    {
        _completed = completed;
    }
}