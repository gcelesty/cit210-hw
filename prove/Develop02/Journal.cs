class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal() { }

    public void Display()
    {
        // iterate thrugh each entry in the list and display it
        //Console.WriteLine("Displaying the journal");  
 
        // entry.GetEntry();

    
            _entries.ForEach(entry =>
            {
                Console.WriteLine(entry.GetEntry()); 
            });
            
    }

    public void Save(string file)
    {
        // save all entries out to the file
        Console.WriteLine($"Saved journal to file {file}");

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

        using (StreamWriter outputFile = new StreamWriter($"{file.Split('.')[0]}.csv"))
        {
            _entries.ForEach(entry =>
            {
                outputFile.WriteLine(entry.GetEntry()); 
            });
        }
    }

    public void AddEntry(Entry entry)
    {
        // adds this entry to the list
        _entries.Add(entry);
    }
}
