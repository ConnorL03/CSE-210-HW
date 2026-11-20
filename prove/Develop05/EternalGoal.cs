using System.Security.Cryptography;

public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points): base(title, description, points)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_title} ({_description})");
    }

    public override string SaveToFileFormat()
    {
        return $"EternalGoal,{_title},{_description},{_points}";
    }
}

