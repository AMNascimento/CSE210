public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        _count = 0;
        _prompts.Add("Who are people that you appreciate");
        _prompts.Add("What are personal strengths of yours");
        _prompts.Add("Who are people that you have helped this week");
        _prompts.Add("When have you felt the Holy Ghost this month");
        _prompts.Add("Who are some of your personal heroes");
    }

    public void Run()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()}? ---");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_count} items!");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            list.Add(Console.ReadLine());
            _count++;
        }
        return list;
    }
}