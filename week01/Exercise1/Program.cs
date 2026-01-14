using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"{lastname}, My name is {name} {lastname}.");
    }
}