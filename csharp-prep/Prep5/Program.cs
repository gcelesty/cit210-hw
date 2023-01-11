using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
        // static allows you to call the function w/o any context
        // voids do not have parameters or return type
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
        
        // string function returns a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

        // int function returns a number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}