using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it's a perfect number:");
        if (int.TryParse(Console.ReadLine(), out int inputNumber))
        {
            if (IsPerfect(inputNumber))
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not A Perfect Number");
            }
        }
    }

    static bool IsPerfect(int number)
    {
        int sum = 0;

        // Calculate the sum of divisors
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}
