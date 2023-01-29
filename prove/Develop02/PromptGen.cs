class PromptGen
{
    public List<string> _prompt = new List<string>();

    public string GetRandomPrompt()
    {
        this._prompt.Add(new string("What is due this week? "));
        this._prompt.Add(new string("What is your favorite class? "));
        this._prompt.Add(new string("What is your major? "));
        this._prompt.Add(new string("When are you scheduled to graduate? "));
        this._prompt.Add(new string("What is your dream job? "));
        this._prompt.Add(new string("What do you do in your free time? "));
        this._prompt.Add(new string("What is the best thing about yourself? "));
        
        int index = new Random().Next(0, this._prompt.Count() -1);
        String prompt = this._prompt[index];

        return prompt;
    }
}