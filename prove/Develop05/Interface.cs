public class UserInterface
{
    private GoalManager goalManager = new GoalManager();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "6":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int requiredCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, points, requiredCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void RecordEvent()
    {
        goalManager.DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        goalManager.RecordEvent(goalIndex);
    }
}