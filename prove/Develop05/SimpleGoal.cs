
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) :base(name, description, points)
    {
       
        _isComplete = false;
            
    }
    
    public SimpleGoal(string name, string description, int points, bool isComplete) :base(name, description, points)
    {
       
        _isComplete = isComplete;
            
    }
    public override void RecordEvent()
    {
       _isComplete = true;
       Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }


}