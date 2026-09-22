using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    
    {
        
        List <int> numbers = new List<int> ();
        int number = 1;
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
               numbers.Add (number);
            }
        } while (number != 0);

        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        Console.WriteLine($"The sum is: {total}");

        int average = total / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int highest_num = 0;
        foreach (int num in numbers)
        {
            if (num> highest_num)
            {
                highest_num = num;
            }
        }
        Console.WriteLine($"The largest number is: {highest_num}");

    }
}