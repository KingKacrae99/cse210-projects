using System;

public class Entry{
    public string _prompt;
    public string _userResponse;
    public string _date;
    
    public void DisplayEntry(){
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"prompt: {_prompt}");
        Console.WriteLine($"Response: {_userResponse}");
        Console.WriteLine("-----------------------------");
    }
}