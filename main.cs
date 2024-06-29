using System;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            // display motto on load
            DisplayMotto();
            // show menu
            ShowMenu();
        }

        // method to display motto
        static void DisplayMotto()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine();
        }

        // method to show menu
        static void ShowMenu()
        {
            while (true) // loop to keep menu displayed until user exits
            {
                Console.WriteLine("Please Enter the following number below from the following menu:");
                Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");

                // user input
                string input = Console.ReadLine();

                // perform action based on input
                switch (input)
                {
                    case "1":
                        // user selects option 1, calc revenue
                        CalculateRevenue();
                        break;
                    case "2":
                        // user selects option 2, exit the app
                        ExitApp();
                        return;
                    default:
                        // input is invalid, display error msg
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
            }
        }

        // method to calc revenue based on num contestants
        static void CalculateRevenue()
        {
            // prompt user to enter num contestants in previous year
            Console.WriteLine("Enter number of contestants in previous year:");
            int lastYearContestants = int.Parse(Console.ReadLine());

            // prompt user to enter num contestants in current year
            Console.WriteLine("Enter number of contestants in current year:");
            int currentYearContestants = int.Parse(Console.ReadLine());

            // fee per contestant
            const int feePerContestant = 25;
            // calc expected revenue
            int expectedRevenue = currentYearContestants * feePerContestant;

            // display results
            Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants");
            Console.WriteLine($"Revenue expected this year is ${expectedRevenue.ToString("N0")}");
            Console.WriteLine($"It is {(currentYearContestants > lastYearContestants ? "true" : "false")} that this year's competition is bigger than last year's.");
            Console.WriteLine();

            // display motto again
            DisplayMotto();
        }

        // method to exit the app
        static void ExitApp()
        {
            Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
            // exit the app
            Environment.Exit(0);
        }
    }
}
