class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _completed;
    protected int? _bonusQualification;
    protected int? _timesCompleted;
    protected int? _bonusPoints;

    public Goal() { this._completed = false; }

    public virtual int CompleteGoal()
    {
        this._completed = true;
        return this._points;
    }
    
    public virtual string DisplayFormatted()
    {
        string mark = this._completed ? "X" : " ";
        return $"[{mark}] {this._name} — {this._description}";
    }
}