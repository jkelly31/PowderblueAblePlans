using System;

class Program {

      static void Main()
      {
        const double CentimetersPerInch = 2.54;
        
        Console.WriteLine("Enter the measurement in inches:");
        
        double inches = double.Parse(Console.ReadLine()); // accept value from user
        
        double centimeters = inches * CentimetersPerInch;
        
        Console.WriteLine($"{centimeters} centimeters");
      }
  }

  
    
    //Console.WriteLine("({0} + {1}) * {2} = {3}", x, y, z, total);
    //Console.WriteLine("The value of y is {0}", y);
    
    //string declareString = "Declared String";
    //Console.Write(declareString);

    //var fullName = ConcatName("Julia", "Kelly");
    //Console.WriteLine("Hello world! {0} is here and {1} likes cats", fullName, fullName);

