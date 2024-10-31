using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(30, 4.55m);
        Cycling cycling = new Cycling(60, 35m);
        Swimming swimming = new Swimming(25, 40);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        
        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}