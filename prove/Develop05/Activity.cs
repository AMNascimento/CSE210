public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _duration = 30;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}.");
        Console.Write($"\nHow long, in seconds, would you like for our session? ");
        Int32.TryParse(Console.ReadLine(), out _duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell Done!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
}