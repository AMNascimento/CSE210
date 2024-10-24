// Creativity: To exceed requirements I did the following:
// 1- Added the option for the user to unhide words in case they don't remember them.
// The user can chose a word to show or they can chose to show all words.

using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        
        Reference reference = new Reference("1 Nefi", 3, 7);
        Scripture scripture = new Scripture(reference, text);

        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue; type 'show' to unhide a word or type 'quit' to finish:");
            userInput = Console.ReadLine().ToLower();
            
            if (userInput == "show")
            {
                Console.WriteLine("\nType the word position number; or type 'all' to show all words.");
                scripture.ShowWords(Console.ReadLine().ToLower()); //Probably not best practice, but I'm short on time.
            }else
            {
                if (scripture.IsCompletlyHidden())
                {
                    break;
                }
                scripture.HideRandomWords(3);
            }
        }
    }
}