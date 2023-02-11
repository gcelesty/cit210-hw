using System;

class Program
{

    static void Main(string[] args)
    {
        Randomizer generator = new Randomizer();
        ListOfScript choiceOne = new ListOfScript();
        ListOfScript choiceTwo = new ListOfScript();
        ListOfScript choiceThree = new ListOfScript();
        ListOfScript choiceFour = new ListOfScript();
        ListOfScript choiceFive = new ListOfScript();
        HidingWords hide = new HidingWords();

        Console.WriteLine("");
        Console.WriteLine("Ready for BOM Scripture Mastery? ");
        Console.WriteLine("");

        string choice = "";

        
        DisplayMenu();
        Console.WriteLine("");
        Console.Write("Pick a number 1-6: ");
        choice = Console.ReadLine();
        Console.WriteLine("");

        if (choice == "1")
        {
            // 1 Nephi 7:12
            string scriptureOne = choiceOne.scriptureOne();
            Console.WriteLine(scriptureOne);

            Console.WriteLine(hide.HidingOne(scriptureOne));
        }
        else if (choice == "2")
        {       
            // 2 Nephi 31:19
            string scriptureTwo = choiceTwo.scriptureTwo();
            Console.WriteLine(scriptureTwo);

            Console.WriteLine(hide.HidingTwo(scriptureTwo));
        }
        else if (choice == "3")
        {
            // Alma 32:21
            string scriptureThree = choiceThree.scriptureThree();
            Console.WriteLine(scriptureThree);

            Console.WriteLine(hide.HidingThree(scriptureThree));
        }
        else if (choice == "4")
        {
            // Ether 12:6
            string scriptureFour = choiceFour.scriptureFour();
            Console.WriteLine(scriptureFour);

            Console.WriteLine(hide.HidingFour(scriptureFour));
        }
        else if (choice == "5")
        {
            // Ether 7:33
            string scriptureFive = choiceFive.scriptureFive();
            Console.WriteLine(scriptureFive);

            Console.WriteLine(hide.HidingFive(scriptureFive));
        }
        else if (choice == "6")
        {
            // random
            string ranScripture = generator.RandomScripture();
            Console.WriteLine(ranScripture);
            
            Console.WriteLine(hide.HidingRandom(ranScripture));
        }

        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'q' to finish: ");
        Console.WriteLine("");


        // ADD THE RANDOM HIDING HERE
        // Console.WriteLine(hide.Hiding(scriptureOne));

        // if statment to quit program
        

        static void DisplayMenu() 
        {
            Console.WriteLine("1. 1 Nephi 7:12");
            Console.WriteLine("2. 2 Nephi 31:19");
            Console.WriteLine("3. Alma 32:21");
            Console.WriteLine("4. Ether 12:6");
            Console.WriteLine("5. Ether 7:33");
            Console.WriteLine("6. Random Scripture from above");
            Console.WriteLine("7. Quit");
        }
    }
}