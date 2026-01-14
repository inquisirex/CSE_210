using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write your grade");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter = ("NA");
        bool passed = false;

        if (gradeInt >= 90)
        {
            letter = ("A");
            passed = true;
        }
        else if (gradeInt >= 80)
        {
            letter = ("B");
            passed = true;
        }
        else if (gradeInt >= 70)
        {
            letter = ("C");
            passed = true;
        }
        else if (gradeInt >= 60)
        {
            letter = ("D");
            passed = false;
        }
        else
        {
            letter = ("F");
            passed = false;
        }

        if (passed == true)
        {
            Console.Write($"Congratulations! you passed this class with an {letter}.");
        }
        else
        {
            Console.Write($"You did not pass this class. Your grade was {letter}");
        }
    }
}