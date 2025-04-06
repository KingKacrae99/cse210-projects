using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John", "programming with Java");
        MathAssignment maths = new MathAssignment("Roberto","Fractions","7.3","8-19");
        WritingAssignment written= new WritingAssignment("Mary waters","Historology of Christianity","Reign of the Roman Empire");

        Console.WriteLine(maths.GetSummary());
        Console.WriteLine(maths.GetHomeworkList());
        Console.WriteLine("");
        Console.WriteLine(written.GetSummary());
        Console.WriteLine(written.GetWritingInformation());
    }
}