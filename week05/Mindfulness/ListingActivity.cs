public class ListingActivity : Activity{
    private List<string> prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "When have you felt the Holy Ghost this month?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };
    public void StartListingActivity(){
        StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random RandomGenerator = new Random();
        string prompt = prompts[RandomGenerator.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        List<string> items = new List<string>();
        Console.WriteLine("Start listing your items now.");
        Countdown();
        Console.WriteLine("Time to start listing!");
        for(int i =0; i < _duration; i++){
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        Console.WriteLine($"You Listed {items.Count} items.");
        EndActivity("Listing");
    }
}