using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        string response = "yes";

        while (response.ToLower() == "yes"){

            int magicNumber = randomGenerator.Next(1,100);
            int number = 0;
            int attempts = 0;

            while(number != magicNumber ){

                Console.WriteLine("What is the magic number? ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                attempts += 1;

                if (number > magicNumber){
                    Console.WriteLine("Lower");
                }
                else if (number < magicNumber){
                    Console.WriteLine("Higher");
                }
                
            }

            Console.WriteLine($"You guessed right! attempt: {attempts} times");
            Console.Write("Do you want to play again. (yes or no)? ");
            response = Console.ReadLine();
       }
    }
}