public class ChecklistGoal : Goal {
    
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, int points, int targetCount, int bonus) : base(name, points){
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent(){
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStatus(){
        return $"[{_currentCount}/{_targetCount}] {_name}";
    }

    public override string Serialize(){
        return $"Checklist|{_name}|{_points}|{_targetCount}|{_currentCount}|{_bonus}";
    }
}