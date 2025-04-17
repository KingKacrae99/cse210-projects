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
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "simple")
                        manager.AddGoal(new SimpleGoal(name, points));
                    else if (type == "eternal")
                        manager.AddGoal(new EternalGoal(name, points));
                    else if (type == "checklist")
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, points, target, bonus));
                    }
                    break;
                case "2":
                    manager.DisplayGoals();
                    Console.Write("Select goal number to record event: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(index);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.SaveGoals("goals.txt");
                    break;
                case "5":
                    manager.LoadGoals("goals.txt");
                    break;
                case "6":
                    return;
            }
        }
    }
}