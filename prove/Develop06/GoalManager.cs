using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string option = "";
        while (option !=  "6")
        {
            DiplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice form the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                CreateGoal();
            } else if (option == "2")
            {
                Console.WriteLine("The Goals are:");
                ListGoalDetails();
            } else if (option == "3")
            {
                SaveGoals();
            } else if (option == "4")
            {
                LoadGoals();
            } else if (option == "5")
            {
                RecordEvent();
            } else if (option != "6")
            {
                Console.WriteLine("\nInvalid Option!");
            }
        }
    }

    public void DiplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Bad Habit Goal");
        Console.Write("Which Goal would you like to create: ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            Console.Write("What is the name of your goal?  ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?  ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points assotiated with this goal?  ");
            int points = Int32.Parse(Console.ReadLine());
            
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }else if (option == "2")
        {
            Console.Write("What is the name of your goal?  ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?  ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points assotiated with this goal?  ");
            int points = Int32.Parse(Console.ReadLine());

            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }else if (option == "3")
        {
            Console.Write("What is the name of your goal?  ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?  ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points assotiated with this goal?  ");
            int points = Int32.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
            int target = Int32.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?  ");
            int bonus = Int32.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }else if (option == "4")
        {
            Console.Write("What is the name of your goal?  ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it?  ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points assotiated with this goal?  ");
            int points = Int32.Parse(Console.ReadLine());

            BadHabitGoal goal = new BadHabitGoal(name, description, points);
            _goals.Add(goal);
        }else
        {
            Console.WriteLine("\nInvalid Option!");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The Goals are:");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? ");
        int goalPosition = Int32.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[goalPosition].RecordEvent();
        _score += pointsEarned;

        if (pointsEarned > 0)
        {
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        }else if (pointsEarned < 0)
        {
            Console.WriteLine($"Sorry to hear that. You have lost {pointsEarned} points!");
        }else
        {
            Console.WriteLine($"You earned no points. Try accomplishing another goal.");
        }
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = Int32.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            ReCreateGoal(lines[i]);
        }
    }

    private void ReCreateGoal(string goalStringRepresentation)
    {
        string[] parts = goalStringRepresentation.Split(":");
        string goalType = parts[0];
        string[] goalData = parts[1].Split(",");
        
        if (goalType == "SimpleGoal")
        {
            SimpleGoal goal = new SimpleGoal(goalData[0], goalData[1], Int32.Parse(goalData[2]));
            if (goalData[3] == "True")
            {
                goal.MarkComplete();
            }
            _goals.Add(goal);
        } else if (goalType == "EternalGoal")
        {
            EternalGoal goal = new EternalGoal(goalData[0], goalData[1], Int32.Parse(goalData[2]));
            _goals.Add(goal);
        } else if (goalType == "ChecklistGoal")
        {
            ChecklistGoal goal = new ChecklistGoal(goalData[0], goalData[1], Int32.Parse(goalData[2]), Int32.Parse(goalData[3]), Int32.Parse(goalData[4]));
            for (int i = 0; i < Int32.Parse(goalData[5]); i++)
            {
                goal.CompleteOne();
            }
            _goals.Add(goal);
        } else if (goalType == "BadHabitGoal")
        {
            BadHabitGoal goal = new BadHabitGoal(goalData[0], goalData[1], Int32.Parse(goalData[2]));
            _goals.Add(goal);
        }
    }
}