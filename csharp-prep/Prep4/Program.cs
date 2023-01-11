using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //creating the list with user input
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");

            string answer = Console.ReadLine();
            userNumber = int.Parse(answer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
    
        // calculating sum of numbers in list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // calculating the average of numbers in list
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        // calculating the max number in the list
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}