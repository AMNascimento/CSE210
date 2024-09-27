using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int magicNumber;
        int guess;
        int attempts;
        string exit;

        do
        {
            magicNumber = randomGenerator.Next(1, 100);
            attempts = 0;
            // Console.WriteLine(magicNumber);

            do
            {
                attempts++;
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it! You used {attempts} guesses");
                }
            }while (guess != magicNumber);

            Console.WriteLine("Would you like to play again?");
            exit = Console.ReadLine();

        } while (exit == "yes");
    }
}