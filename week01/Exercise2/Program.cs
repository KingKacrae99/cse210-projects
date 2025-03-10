using System;

class Program
{
    static void Main(string[] args)
    {  
        string letter = "";
        string sign = "";

        Console.Write("What's you grade? ");
        string score = Console.ReadLine();
        int studentScore = int.Parse(score);
        
        if (studentScore >= 90){
            letter = "A";
        }
        else if (studentScore >=80){
            letter = "B";
        }
        else if (studentScore >=70){
            letter = "C";
        }
        else  if (studentScore >= 60) {
            letter = "D";
        }
        else{
            letter = "F";
        }

        int lastnum = studentScore % 10;

        if (letter != "A" && letter != "F"){
            if(lastnum >= 7){
                sign = "+";
            }
            else if(lastnum < 3){
                sign ="-";
            }
        }
        else if (letter == "A" && studentScore < 97){
            if(lastnum < 3){
                sign = "-";
            }
        }

        Console.WriteLine($"Your Score: {studentScore}, Grade: {letter}{sign}.");



        if (studentScore >= 70 ){
            Console.Write("Congratulations! You passed.");
        }
        else{
            Console.Write("You failed! you can do better next time.");
        }
    }
}