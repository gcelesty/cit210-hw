class GoalService
{
    private List<Goal> _goals;
    private int _score;

    public GoalService() {}

    public void CreateGoal()
    {
        Console.WriteLine();
    }

    public void PrintGoals()
    {
        Console.WriteLine("These are the goals:");
        Console.WriteLine();
        foreach (var g in this._goals.Select((goal, index) => (goal, index)))
        {
            Console.WriteLine($"{g.index + 1}. {g.goal.DisplayFormatted()}");
        }
        Console.WriteLine();
    }

        public void SaveFile(string file)
    {
        if (file == null)
        {
            Console.WriteLine();
            Console.Write("Please, enter the a name to save the file: ");
            file = Console.ReadLine();
        }

    }

    public void LoadFile(string file)
    {
        if (file == null)
        {
            Console.WriteLine();
            Console.Write("Please, enter the file name to load: ");
            file = Console.ReadLine();
        }
    }

    public void CreateSimpleGoal(string name, string description, int points)
    {
        this._goals.Add(new Goal(true));
    }

    public void CreateCheckListGoal(string name, string description, int points) 
    { 
        this._goals.Add(new EternalGoal(true));
    }

    public void CreateEternalGoal(string name, string description, int points) 
    { 
        this._goals.Add(new CheckListGoal(true));
    }
}