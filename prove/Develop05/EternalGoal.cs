class EternalGoal : Goal
{
    public EternalGoal() : base() { }
    public EternalGoal(bool initialize) { }

    public override int CompleteGoal()
    {
        return _points;
    }
}