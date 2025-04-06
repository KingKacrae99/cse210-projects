public class BreathingActivity : Activity
{
    public void StartBreathingActivity(){
        StartActivity("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on the breathing.");

        for (int i = 0; i < _duration / 4; i++){
            Console.WriteLine("Breathe in...");
            Countdown();
            Console.WriteLine("Breathe out...");
            Countdown();
        }

        EndActivity("Breathing");
    }
}