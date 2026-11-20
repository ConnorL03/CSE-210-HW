public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, string description, int points, bool completed)
        : base(title, description, points)
    {
        _completed = completed;
    }

    public bool IsCompleted
    {
        get { return _completed; }
        set { _completed = value; }
    }
    
    public override void Display()
    {
        if(_completed == true)
        {
            Console.WriteLine($"[x] {_title} ({_description})");
        }

        else if (_completed == false)
        {
            Console.WriteLine($"[ ] {_title} ({_description})");
        }
    }
    public override string SaveToFileFormat()
    {
        return $"SimpleGoal,{_title},{_description},{_points},{_completed}";
    }
}
