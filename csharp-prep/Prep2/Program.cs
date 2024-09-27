using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter;
        string signal = "";
        int remeinder = grade%10;


        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade < 70)
        {
            letter = "D";
        }
        else if (grade < 80)
        {
            letter = "C";
        }
        else if (grade < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }

        if (grade >= 60 && grade < 90 && remeinder >= 7)
        {
            signal = "+";
        }
        else if (grade >= 60 && remeinder < 3 && grade != 100)
        {
            signal = "-";
        }

        Console.WriteLine($"Your grade is {letter}{signal}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed!}");
        }
        else
        {
            Console.WriteLine("Keep trying. You'll do better next time!");
        }
    }
}