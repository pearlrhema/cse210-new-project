using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("7.9","9-16");
        assignment.SetStudentName("Godwin Akpan Essien");
        assignment.SetTopic("Fractions");
        MathAssignment math = new("Godwin Essien","Fractions", "7.9","9-16");
        // math.SetSection("7.3");
        // math.SetProblem("8-19");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(math.GetHomeWorkList());
    }
}