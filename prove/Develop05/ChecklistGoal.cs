public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amount) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
    }
    
    
    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (_amountCompleted < _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!"); 
        }
        else if(_amountCompleted == _target)
        {
            _points += _bonus;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
        else if(_amountCompleted > _target)
        {
            _amountCompleted--;
            Console.WriteLine($"You have already completed this goal");

        }

    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

}