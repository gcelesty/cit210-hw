using System;

class Program
{
    static void Main(string[] args)
    {
        // RECEPTION = YELLOW
        Console.ForegroundColor = ConsoleColor.Yellow;

        // reception - reynolds wedding recepetion
        Address address1 = new Address("250 Haiku Rd", "Haiku", "Hawaii", 96708, "USA");
        Receptions reception1 = new Receptions("Reynolds' Wedding", "Wedding reception for Ryan Reynolds and Blake Lively", "May 18th, 2022", "8pm-2am", address1, "Reception","rreynolds2012@gmail.com");
        
        // reception - standard details
        Console.WriteLine(reception1.StandardDetails());
        Console.WriteLine();

        // reception - full details
        Console.WriteLine(reception1.FullDetails() + reception1.ReceptionFullDetails());
        Console.WriteLine();

        // reception - short details
        Console.WriteLine(reception1.ShortDetails());
        Console.WriteLine();



        // OUTDOOR = GREEN
        Console.ForegroundColor = ConsoleColor.Green;

        // outdoor - houston rodeo
        Address address2 = new Address("3 NRG Pkwy", "Houston", "Texas", 77054, "USA");
        Outdoor outdoor1 = new Outdoor("Houston Rodeo","Livestock Show and Rodeo", "February 28th, 2023","4pm-11pm", address2, "Outdoor", "Sunny with no clouds");

        // outdoor - standard details
        Console.WriteLine(outdoor1.StandardDetails());
        Console.WriteLine();

        // outdoor - full details
        Console.WriteLine(outdoor1.FullDetails() + outdoor1.OutdoorFullDetails());
        Console.WriteLine();

        // outdoor - short details
        Console.WriteLine(outdoor1.ShortDetails());
        Console.WriteLine();



        // LECTURE = DARK MAGENTA
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        // lecture - taylor building
        Address address3 = new Address("525 S Center St", "Rexburg", "Idaho", 83440, "USA");
        Lecture lecture1 = new Lecture("Orientation for college", "Preparing BYUI structure and classes. Any questions will be answered", "April 17th, 2023", "9-11am", address3, "Lecture", "Henry J. Eyring", 15000);
        
        // lecture - standard details
        Console.WriteLine(lecture1.StandardDetails());
        Console.WriteLine();

        // lecture - full details
        Console.WriteLine(lecture1.FullDetails() + lecture1.LectureFullDetails());
        Console.WriteLine();

        // lecture - short details
        Console.WriteLine(lecture1.ShortDetails());
    }
}