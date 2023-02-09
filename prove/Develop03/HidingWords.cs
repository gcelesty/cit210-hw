class HidingWords
{
    public List<string> _hiding = new List<string>();
    public string Hiding(string scriptureOne)
    {

        // Console.Clear();
        Console.WriteLine("");

       string[] words = scriptureOne.Split(' ');

        Console.WriteLine("Gonna hide 7 words");
       for(int i = 0; i < 7; i++)
       {
            int index = new Random().Next(0, words.Count() -1);
            string word = words[index];

            // if word is already hidden 
            // i -= 1
            words[index] = new string('_', word.Count());
       }

       return String.Join(" ", words);
   }
}