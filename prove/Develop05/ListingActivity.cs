public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        
    }

    private void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        return list;
    }
}