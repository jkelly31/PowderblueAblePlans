using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        const int MinTemp = -30;
        const int MaxTemp = 130;
        const int NumDays = 5;
        List<int> temperatures = new List<int>();

        Console.WriteLine($"Please enter {NumDays} daily temperatures between {MinTemp} and {MaxTemp}:");

        for (int i = 0; i < NumDays; i++)
        {
            int temp;
            while (true)
            {
                Console.Write($"Temperature {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out temp) || temp < MinTemp || temp > MaxTemp)
                {
                    Console.WriteLine($"Temperature {temp} is invalid. Please enter a valid temperature between {MinTemp} and {MaxTemp}");
                }
                else
                {
                    break;
                }
            }
            temperatures.Add(temp);
        }

        bool gettingWarmer = true;
        bool gettingCooler = true;

        for (int i = 1; i < temperatures.Count; i++)
        {
            if (temperatures[i] <= temperatures[i - 1])
            {
                gettingWarmer = false;
            }
            if (temperatures[i] >= temperatures[i - 1])
            {
                gettingCooler = false;
            }
        }

        if (gettingWarmer)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (gettingCooler)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        string tempList = string.Join(", ", temperatures);
        double averageTemp = temperatures.Average();
        Console.WriteLine($"5-day Temperature [{tempList}]");
        Console.WriteLine($"Average Temperature is {averageTemp:F1} degrees");
    }
}
