using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager{
    
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public List<Goal> Goals => _goals;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoalEvent(int index)
    {
        _score += _goals[index].RecordEvent();
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
        Console.WriteLine($"Total Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.Serialize());
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "Simple":
                    AddGoal(new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
                    break;
                case "Eternal":
                    AddGoal(new EternalGoal(parts[1], int.Parse(parts[2])));
                    break;
                case "Checklist":
                    var goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    AddGoal(goal);
                    break;
            }
        }
    }
}