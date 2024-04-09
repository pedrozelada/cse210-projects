public class Exercise : Habit
{
    private int _weeks; 
    public Exercise(string name, string description, int time) : base(name, description)
    {
        
    }

    public override void GenerateRandom()
    {
        throw new NotImplementedException();
    }

    public override void SelectOne()
    {
        throw new NotImplementedException();
    }

    public override void Tracking()
    {
        throw new NotImplementedException();
    }
}