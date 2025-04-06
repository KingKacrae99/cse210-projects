public class Activity{
    protected int _duration;

    public void StartActivity(string activityName, string description){
        Console.WriteLine($"Welcome to the {activityName}!");
        Console.WriteLine(description);
        Console.WriteLine("Please enter the duration of the activity in seconds");
        string duration =Console.ReadLine();
        _duration = int.Parse(duration);
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);
    }

    public void EndActivity(string activityName){
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed the {activityName} activity.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        Thread.Sleep(3000);
    }
    public void Countdown(){
        for (int i = _duration; i > 0; i--){
            Console.Clear();
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }
}