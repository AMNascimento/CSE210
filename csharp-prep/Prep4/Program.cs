using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int total = 0;
        int max = -9999;
        int min = 9999;
        float avg;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }while (number != 0);

        foreach (int n in numbers)
        {
            total += n;

            if (n > max)
            {
                max = n;
            }

            if (n > 0 && n < min)
            {
                min = n;
            }

        }

        avg = (float)total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine($"The sorted list is: ");
        
        numbers.Sort();
        foreach(int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}