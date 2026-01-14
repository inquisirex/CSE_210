using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello please enter digits to this sum, enter 0 when done.");
        List<int> numbers = new List<int>();
        int totalSum = 0;
        int lastNumber = -1;

        //Get numbers and calculate total sum
        while (lastNumber != 0)
        {
            Console.WriteLine("Please input a number: ");
            string lasNumberStr = Console.ReadLine();
            lastNumber = int.Parse(lasNumberStr);
            totalSum += lastNumber;
            if (lastNumber != 0)
            {
                numbers.Add(lastNumber);
            }
        }

        // Find average //
        
        int numbersOfEntries = numbers.Count;
        decimal average = (decimal)totalSum/(decimal)numbersOfEntries;

        // Find largest index 
        int largestInteger = 0;
        foreach (int number in numbers)
        {
            if (number >= largestInteger)
            {
                largestInteger = number;
            }
        }
        Console.WriteLine($"The sum of your numbers is {totalSum}");
        Console.WriteLine($"The average of the entries is {average}");
        Console.WriteLine($"The biggest entry is {largestInteger}");
    }
}