using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Counting up to your number:");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}