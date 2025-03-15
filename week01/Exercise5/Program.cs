using System;

class Program
{
    static void Main(string[] args)
    {

        static string DisplayWelcome(){
            return  "Welcome to the Program!";
        }
        static string PromptUserName(){
            Console.WriteLine("Please enter your name:");
            string userName= Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber(){
            Console.WriteLine("Please enter your favorite number:");
            string userReply= Console.ReadLine();
            int userNumber = int.Parse(userReply);
            return userNumber;
        }
        static int SquareNumber(int userNumber){
            int squr = userNumber * userNumber;
            return squr;
        }

        static void MainCall(){
            Console.WriteLine($"{DisplayWelcome()}");
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squr = SquareNumber(userNumber);
            Console.WriteLine($"{userName}, the square of your number is {squr}");
        }
        MainCall();
    }
}