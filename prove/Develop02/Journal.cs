class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        // iterate thrugh each entry in the list and display it
        Console.WriteLine("Displaying the journal");        
    }

    public void Save(string file)
    {
        // save all entries out to the file
        Console.WriteLine($"Saving journal to file {file}");
        this._entries=AddEntry(_entries);

        using (StreamWriter outputFile = new StreamWriter($"{file.Split('.')[0]}.csv"))
        {
            _entries.ForEach(entry =>
            {
                outputFile.WriteLine(entry.GetEntry()); 
            });
        }
    }

    private List<Entry> AddEntry(List<Entry> entries)
    {
        throw new NotImplementedException();
    }

    public void Load(string file)
    {
        // load all the entries from the file
        Console.WriteLine($"Loading jounral file {file}");

        string[] lines = System.IO.File.ReadAllLines($"{file.Split('.')[0]}.csv");
        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] attr = line.Split(';');

            loadedEntries.Add(new Entry(attr[2], attr[1], attr[0]));
        }
    }

    public void AddEntry(Entry entry)
    {
        // adds this entry to the list
    }
}