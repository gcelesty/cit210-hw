using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGen generator = new PromptGen();
        
        Console.WriteLine("Welcome to Journal Program");

        string choice = "";

        while (choice != "5")
        {
            DisplayMenu();
            Console.WriteLine("What do you want to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // write
                Console.WriteLine("Writing a new entry");

                // get a new prompt & display it
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                // get the users response text
                Console.Write("> ");
                string response = Console.ReadLine();

                // get current date and save it as a string
                DateTime currentTime = DateTime.Now;
                string date = currentTime.ToShortDateString();

                // create the entry object
                Entry theEntry = new Entry();
                theEntry._date = date;
                theEntry._prompt = prompt;
                theEntry._text = response;


                // add it to the journal
                theJournal.AddEntry(theEntry);

            }
            else if (choice == "2")
            {
                // display
                theJournal.Display();
            }
            else if (choice == "3")
            {
                // save
                Console.Write("What is the name of the new file? ");
                string file = Console.ReadLine();

                theJournal.Save(file);
            }
            else if (choice == "4")
            {
                // load
                Console.Write("What file do you want to load? ");
                string file = Console.ReadLine();

                theJournal.Load(file);               
            }
        }

    }

     static void DisplayMenu()
    {
        Console.WriteLine("1. Write a new entry jounral entry");
        Console.WriteLine("2. Display jounrnal entry");
        Console.WriteLine("3. Save journal");
        Console.WriteLine("4. Load journal");
        Console.WriteLine("5. Exit");
    }


}