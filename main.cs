using System;

class Program
{
    static void Main()
    {
        string[] salespersonNames = { "D", "E", "F" };
        char[] allowedInitials = { 'D', 'E', 'F' };
        int[] sales = new int[allowedInitials.Length];
        int grandTotal = 0;

        Console.WriteLine("Enter a salesperson initial (D, E, or F) or Z to finish:");

        while (true)
        {
            Console.Write("Salesperson initial: ");
            char input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (input == 'Z')
                break;

            int index = Array.IndexOf(allowedInitials, input);

            if (index == -1)
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

            sales[index] += saleAmount;
            grandTotal += saleAmount;
        }

        int highestTotal = 0;
        string highestSalesperson = "";

        for (int i = 0; i < sales.Length; i++)
        {
            if (sales[i] > highestTotal)
            {
                highestTotal = sales[i];
                highestSalesperson = salespersonNames[i];
            }
        }

        string formattedGrandTotal = string.Format("{0:N0}", grandTotal);

        Console.WriteLine($"\nGrand Total: ${formattedGrandTotal}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");

        Console.ReadLine();
    }
}
