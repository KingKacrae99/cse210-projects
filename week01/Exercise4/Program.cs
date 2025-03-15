using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int userInput = -1;
        while(userInput != 0){
            Console.Write("Enter a list of numbers, type 0 when finished.");
            string response = Console.ReadLine();
            userInput = int.Parse(response);

            // Add only numbers that are not zero
            if (userInput != 0){
                numbers.Add(userInput);
            }

        }
        foreach (int value in numbers)
        {
            sum += value;
        }
        Console.WriteLine($"The sum is: {sum}");

        // get average
        if (numbers.Count > 0){
            float average = ((float)sum)/ numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        else{
            Console.WriteLine("List is empty. No number has been entered.");
        }

        // max number
        int max = numbers[0];

        foreach (int value in numbers)
        {
            if (value > max){
                max = value;
            }
        }
        Console.WriteLine($"The max is: {max}");

        // Stretch Challenge
        int smallPostNum = int.MaxValue;
        bool positiveValue = false;
        foreach (int value in numbers)
        {
            if (value > 0 && value < smallPostNum){
                smallPostNum = value;
                positiveValue = true;
            }
        }
        if (positiveValue){
            Console.WriteLine($"The smallest postive number is : {smallPostNum}");
        }
        else{
            Console.WriteLine("No postive value entered.");
        }

        numbers.Sort();
        Console.WriteLine("Sort list is: ");
        foreach (int value in numbers)
        {
            Console.WriteLine(value);
        }

    }
}