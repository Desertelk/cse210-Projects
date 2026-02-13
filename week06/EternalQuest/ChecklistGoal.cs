using System.Runtime.InteropServices.Marshalling;

public class ChecklistGoals : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoals(string name, string description, int points, int amountCompleted, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" has been completed {_amountCompleted} times";
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
}