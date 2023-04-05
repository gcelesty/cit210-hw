using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity1 = new List<Activity>();
        Running run1 = new Running("22 Apr 2023",30 ,"Running", 2);
        activity1.Add(run1);

        Swimming swim1 = new Swimming("28 Jul 2023", 60, "Swimming", 17);
        activity1.Add(swim1);

        Bike bike1 = new Bike("01 May 2023", 60, "Biking", 23);
        activity1.Add(bike1);
        Console.WriteLine();
        Console.WriteLine("Activity List");
        Console.WriteLine();

        foreach (var activity in activity1)
        {
            Console.WriteLine(activity);
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }        
    }
}