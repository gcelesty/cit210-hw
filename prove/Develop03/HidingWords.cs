class HidingWords
{
    public List<string> _hiding = new List<string>();
    public string HidingOne(string scriptureOne)
    {

        // Console.Clear();
        Console.WriteLine("");

       string[] words = scriptureOne.Split(' ');

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

    public string HidingTwo(string scriptureTwo)
    {

        // Console.Clear();
        Console.WriteLine("");

       string[] words = scriptureTwo.Split(' ');

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

    public string HidingThree(string scriptureThree)
    {

        // Console.Clear();
        Console.WriteLine("");

       string[] words = scriptureThree.Split(' ');

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

    public string HidingFour(string scriptureFour)
    {

        // Console.Clear();
        Console.WriteLine("");

       string[] words = scriptureFour.Split(' ');

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

    public string HidingFive(string scriptureFive)
    {

        // Console.Clear();
        Console.WriteLine("");

       string[] words = scriptureFive.Split(' ');

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

    public string HidingRandom(string ranScripture)
    {

        // Console.Clear();
        Console.WriteLine("");

       string[] words = ranScripture.Split(' ');

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