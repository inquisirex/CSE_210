using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string finalName = UserName();
        int finalNum = FavoriteNumber();
        int finalSquaredNum = SquaredNumber(finalNum);
        string finalDisplay = DisplayResult(finalName, finalSquaredNum);
        Console.WriteLine(finalDisplay);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.WriteLine("Please input your name and last name");
        string name = Console.ReadLine();
        return name;
    }

    static int FavoriteNumber()
    {
        Console.WriteLine("Please input your favorite number");
        string strNumber = Console.ReadLine();
        int number = int.Parse(strNumber);
        return number;
    }

    static int SquaredNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static string DisplayResult(string name, int number)
    {
        string strNumber = number.ToString();
        string finalString = $"{name}, the square of your number is {strNumber}";
        return finalString;
    }
}