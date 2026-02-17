using System.ComponentModel;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()},{GetDescription()},{GetPoints()}";
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {

        return false;
    }
}