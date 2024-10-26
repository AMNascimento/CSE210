using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        
        while (option != "4")
        {
            Activity activity = new Activity("test", "test", 5);
            
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            activity.ShowCountDown(9);
            
        }
    }
}