// Creativity: To exceed requirements I did the following:
// 1- For the Reflecting Activity, I Made sure no duplicate questions are selected until 
// they have all been used at least once in that session.

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        
        while (option != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            
            if (option == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndingMessage();
            } else if (option == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.DisplayStartingMessage();
                reflecting.Run();
                reflecting.DisplayEndingMessage();
            } else if (option == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
            }
        }
    }
}