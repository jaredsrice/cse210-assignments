using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Shrek", "Ogre Studies");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Donkey", "Quantum Physics", "1.6", "8-21");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Fiona", "The Art of Ogre Diplomacy", "When an Ogre Becomes an Onion");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}