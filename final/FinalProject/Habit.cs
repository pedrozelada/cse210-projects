public abstract class Habit
{
    protected string _name;
    protected string _description;

    public Habit()
    {
        
    }

    public Habit(string name, string description)
    {
        _name= name;
        _description = description;
    }

    public abstract void Tracking();

    public abstract void GenerateRandom();

    public abstract void SelectOne();

    public string ShowHabbit()
    {
        return $"{_name} ({_description})";
    }

    public string Representation()
    {
        return "";
    }



    
}