using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Create Goal\n2. Record Goal\n3. Show Goals\n4. Save\n5. Load\n6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal type (simple, eternal, checklist): ");
                    string type = Console.ReadLine().ToLower();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    int points = GetIntegerInput("Points: ");

                    if (type == "simple")
                        manager.AddGoal(new SimpleGoal(name, points));
                    else if (type == "eternal")
                        manager.AddGoal(new EternalGoal(name, points));
                    else if (type == "checklist")
                    {
                        int target = GetIntegerInput("Target count: ");
                        int bonus = GetIntegerInput("Bonus: ");
                        manager.AddGoal(new ChecklistGoal(name, points, target, bonus));
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type. Please enter 'simple', 'eternal', or 'checklist'.");
                    }
                    break;

                case "2":
                    manager.DisplayGoals();
                    Console.Write("Select goal number to record event: ");
                    int index = GetIntegerInput("Select goal number") - 1;
                    if (index >= 0 && index < manager.Goals.Count)
                    {
                        manager.RecordGoalEvent(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    break;

                case "3":
                    manager.DisplayGoals();
                    break;

                case "4":
                    try
                    {
                        manager.SaveGoals("goals.txt");
                        Console.WriteLine("Goals saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving goals: {ex.Message}");
                    }
                    break;

                case "5":
                    try
                    {
                        manager.LoadGoals("goals.txt");
                        Console.WriteLine("Goals loaded successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading goals: {ex.Message}");
                    }
                    break;

                case "6":
                    Console.WriteLine("Exiting program.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static int GetIntegerInput(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}