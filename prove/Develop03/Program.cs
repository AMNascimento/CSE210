using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        
        Reference reference = new Reference("1 Nefi", 3, 7);
        Scripture scripture = new Scripture(reference, text);

        while (userInput != "quit" & !scripture.IsCompletlyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.HideRandomWords(3);
        }
    }
}