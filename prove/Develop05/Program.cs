using System;

class Program
{
    static void Main(string[] args)
    {
    }

    static int MenuOption()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List My Goals");
        Console.WriteLine(" 3. Save My Goals (to file)");
        Console.WriteLine(" 4. Load My Goals (from file)");
        Console.WriteLine(" 5. Record Event (goal completion)");
        Console.WriteLine(" 6. Quit");

        Console.Write("Please enter a valid option number: ");
        return int.TryParse(Console.ReadLine(), out int i) ? i : 0;
    }

    static void Action(int option)
    {
        switch (option)
        {
            case 1:
                GoalService.CreateGoal();
                break;
            case 2:
                GoalService.PrintGoal();
                break;
            case 3:
                GoalService.SaveFile(null);
                break;
            case 4:
                GoalService.LoadFile(null);
                break;
            case 5:
                GoalService.CompleteGoal();
                break;
            case 6:
                Console.WriteLine();
                Console.WriteLine("Quitting program...");

                if (GoalService.GetScore() > 0)
                {
                    Console.WriteLine("Saving...");
                    GoalService.SaveFile("autosave");
                }
                break;

            default:
                Console.WriteLine("Please enter a valid option or quit the program");
                break;
        }
    }
}