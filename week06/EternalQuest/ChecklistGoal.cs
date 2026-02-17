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
        return base.GetDetailsString() + $" -- Completed {_amountCompleted}/{_target}";
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints},{_amountCompleted},{_target},{_bonus}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }
}