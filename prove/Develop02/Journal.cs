class Journal
{
    public string _date;
    public string _prompt;
    public string _text;
    public List<Entry> _entries = new List<Entry>();

    public Journal() { }

    public void Display()
    {   
       // _entries.ForEach(entry =>
        //{
         //   Console.WriteLine(entry.GetEntry()); 
        //});

        Console.WriteLine("");
        Console.WriteLine($"Date: {this._date} - {this._prompt}");
        Console.WriteLine($">> {this._text}");
        Console.WriteLine("");
            
    }

    public void Save(string file)
    {
        // save all entries out to the file
        Console.WriteLine($"Saved journal to file {file}");

    }


    public void Load(string file)
    {
        // load all the entries from the file
        Console.WriteLine($"Loading journal file {file}");

        string[] lines = System.IO.File.ReadAllLines(file);
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
