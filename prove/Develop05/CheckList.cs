using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal
{
	private int _bonusPoints;
	private int _timesCompleted;
	private int _timesToComplete;

	public ChecklistGoal(string title, string description, int points, int timesToComplete, int bonusPoints, int timesCompleted)
		: base(title, description, points)
	{
		_bonusPoints = bonusPoints;
		_timesCompleted = timesCompleted;
		_timesToComplete = timesToComplete;
	}

	public override void Display()
    {
        if(_timesCompleted < _timesToComplete)
        {
            Console.WriteLine($"[ ] {_title} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
        }
        else if (_timesCompleted >= _timesToComplete)
        {
            Console.WriteLine($"[x] {_title} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
        }
    }

	public void UpdateTimesCompleted()
	{
		_timesCompleted ++;
	}
	public int CheckBonusPoints()
	{
		if(_timesCompleted >= _timesToComplete)
		{
			return _bonusPoints;
		}

		return 0;
	}

	public override string SaveToFileFormat()
	{
		return $"ChecklistGoal,{_title},{_description},{_points},{_bonusPoints},{_timesToComplete},{_timesCompleted}";
	}
    
    
}
