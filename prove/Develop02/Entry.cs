class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public void Display(string date, string prompt, string response)
    {
        // display the details of the entry
        this._date = date;
        this._prompt = prompt;
        this._text = response;
    }

    public string GetEntry() 
    {
        Console.WriteLine($"Date: {this._date} - {this._prompt}");
        Console.WriteLine($">> {this._text}");

        return $"{this._date};{this._prompt};{this._text}";
    }
}
