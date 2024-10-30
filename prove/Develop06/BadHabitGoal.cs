public class BadHabitGoal : Goal
{
    public BadHabitGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return _points * -1;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"BadHabitGoal:{_shortName},{_description},{_points}";
    }
}