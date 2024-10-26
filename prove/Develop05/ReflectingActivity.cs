public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string>  _questions = new List<string>();

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        _prompts.Add("Think of a time when you stood up for someone else");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless");

        _questions.Add("Why was this experience meaningful to you");
        _questions.Add("Have you ever done anything like this before");
        _questions.Add("How did you get started");
        _questions.Add("How did you feel when it was complete");
        _questions.Add("What made this time different than other times when you were not as successful");
        _questions.Add("What is your favorite thing about this experience");
        _questions.Add("What could you learn from this experience that applies to other situations");
        _questions.Add("What did you learn about yourself through this experience");
        _questions.Add("How can you keep this experience in mind in the future");
    }

    public void Run()
    {
        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press any key to continue.");
        Console.ReadKey();
        Console.WriteLine("\nNow ponder on each of the followig questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
        Console.WriteLine();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"\n --- {GetRandomPrompt()}. ---");
    }

    private void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n> {GetRandomQuestion()}? ");
            ShowSpinner(8);
        }
    }
}