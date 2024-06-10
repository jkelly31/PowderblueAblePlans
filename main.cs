using System;

class Program
{
    static void Main()
    {
        int salesD = 0, salesE = 0, salesF = 0;
        int grandTotal = 0;

        Console.WriteLine("Enter a salesperson initial (D, E, or F) or Z to finish:");

        while (true)
        {
            Console.Write("Salesperson initial: ");
            char input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (input == 'Z')
                break;

            if (input != 'D' && input != 'E' && input != 'F')
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
                continue;
            }

            Console.Write("Sale amount: ");
            if (!int.TryParse(Console.ReadLine(), out int saleAmount))
            {
                Console.WriteLine("Invalid input for sale amount. Please enter a valid number.");
                continue;
            }

            switch (input)
            {
                case 'D':
                    salesD += saleAmount;
                    break;
                case 'E':
                    salesE += saleAmount;
                    break;
                case 'F':
                    salesF += saleAmount;
                    break;
            }

            grandTotal += saleAmount;
        }

        char highestSalesperson = ' ';
        int highestTotal = 0;

        if (salesD > highestTotal)
        {
            highestTotal = salesD;
            highestSalesperson = 'D';
        }
        if (salesE > highestTotal)
        {
            highestTotal = salesE;
            highestSalesperson = 'E';
        }
        if (salesF > highestTotal)
        {
            highestTotal = salesF;
            highestSalesperson = 'F';
        }
        string formattedGrandTotal = string.Format("{0:N0}", grandTotal);

        Console.WriteLine($"\nGrand Total: ${formattedGrandTotal}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");

        Console.ReadLine();
    }
}
