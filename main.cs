using System;

class Program {

      static void Main()
      {
        const double BaseRate = 200.0;
        const double HourlyRate = 150.0;
        const double MileRate = 2.0;

        Console.WriteLine("Enter the number of hours for the job:");
        double hours = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of miles for the move:");
        double miles = double.Parse(Console.ReadLine());

        double totalFee = BaseRate + (hours * HourlyRate) + (miles * MileRate);

        Console.WriteLine($"Total moving fee: ${totalFee:F2}");
      }
  }

  
    
    //Console.WriteLine("({0} + {1}) * {2} = {3}", x, y, z, total);
    //Console.WriteLine("The value of y is {0}", y);
    
    //string declareString = "Declared String";
    //Console.Write(declareString);

    //var fullName = ConcatName("Julia", "Kelly");
    //Console.WriteLine("Hello world! {0} is here and {1} likes cats", fullName, fullName);

