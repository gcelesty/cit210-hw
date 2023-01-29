class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public Entry()
    {
    }

    public Entry(string v1, string v2, string v3)
    {
        V1 = v1;
        V2 = v2;
        V3 = v3;
    }

    public string V1 { get; }
    public string V2 { get; }
    public string V3 { get; }

    public void Display(string date, string prompt, string response)
    {
        // display the details of the entry
        this._date = date;
        this._prompt = prompt;
        this._text = response;
    }

    public string GetEntry() 
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {this._date} - {this._prompt}");
        Console.WriteLine($">> {this._text}");
        Console.WriteLine("");
        
        return $"{this._date};{this._prompt};{this._text}";
    }
}
