// Creativity: To exceed requirements I did the following
// 1- Handling unsaved work. If a user tries to quit the program or load a file while
// there is unsaved work, the program will wanr the user and ask with they would like
// to save it.
// 2- Handle invalid option in the menu selection. The program continues to ask for a
// valid option until one is provided.

using System;

class Program
{
    static void Main(string[] args)
    {
        string menuOption;
        bool saved = true;

        Journal journal = new Journal();

        PromptGenerator prompt = new PromptGenerator();
        prompt._prompts.Add("What was the most surprising thing that happened to me today?");
        prompt._prompts.Add("What did I learn about myself or others today?");
        prompt._prompts.Add("What is one thing I am grateful for that happened today?");
        prompt._prompts.Add("What was the most challenging situation I faced today?");
        prompt._prompts.Add("How did I overcome or deal with my challenges today?");
        prompt._prompts.Add("What was a moment of joy or laughter for me today?");
        prompt._prompts.Add("What was a moment of peace or tranquility for me today?");
        prompt._prompts.Add("What was a moment of frustration or disappointment for me today?");
        prompt._prompts.Add("How did I handle my emotions today?");
        prompt._prompts.Add("What is one thing I want to remember about today?");
        
        Console.WriteLine("\nWelcome to your Journal!");
        
        do
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuOption = Console.ReadLine();

            if ((menuOption == "3" | menuOption == "5") & saved == false)
            {
                string errorPromtOption;
                do
                {
                    Console.WriteLine("You have unsaved work. Would you like to save it (Y/N)?");
                    errorPromtOption = Console.ReadLine().ToUpper();

                    if (errorPromtOption == "Y")
                    {
                        menuOption = "4";
                    }
                    else if (errorPromtOption != "N")
                    {
                        Console.WriteLine("Invalid Option!");
                    }
                } while(errorPromtOption != "Y" & errorPromtOption != "N");
            }
            
            if (menuOption == "1")
            {
                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
                saved = false;
            }
            else if (menuOption == "2")
            {
                journal.DisplayALl();
            }
            else if (menuOption == "3")
            {
                Console.WriteLine("What is the file name to load?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                saved = true;  
            }
            else if (menuOption == "4")
            {
                Console.WriteLine("What is the file name to save?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                saved = true;
            }
            else if (menuOption != "5")
            {
                Console.WriteLine("\nInvalid Option!");
            }
        } while (menuOption != "5");
    }
}