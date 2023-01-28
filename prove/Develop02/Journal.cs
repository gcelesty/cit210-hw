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
    }

    public void Load(string file)
    {
        // load all the entries from the file
        Console.WriteLine($"Loading jounral file {file}");
        // file .Load(Console.ReadLine());
    }

    public void AddEntry(Entry entry)
    {
        // adds this entry to the list
    }
}