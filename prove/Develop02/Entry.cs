class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public void Display(string prompt, string response)
    {
        // display the details of the entry
        this._date = DateTime.Now.ToString();
        this._prompt = prompt;
        this._text = response;
        
    }
}
