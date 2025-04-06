//I Exceeded Requirements by:
// Implementing several features to enchance the user experience:
// Countdown Timer: for each activity, I incorporated a countdown timer
// 2). Randomized prompts:  The Listing and Reflection activities display random prompts
// 3). Interactive Input.


using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4.  Exit");
            Console.Write("Please choose an activity (1-4): ");
            string response = Console.ReadLine();
            int choice = int.Parse(response);

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.StartBreathingActivity();
            } else if(choice ==2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.StartReflectionActivity();
            }else if (choice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.StartListingActivity();
            } else if (choice == 4)
            {
                break;
            } else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
                Thread.Sleep(2000);
            }
        }
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");
    }
}