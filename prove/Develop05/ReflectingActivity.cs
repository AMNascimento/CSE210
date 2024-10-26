public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string>  _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        
    }

    private string GetRandomPrompt()
    {
        return "";
    }

    private string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {
        
    }
}