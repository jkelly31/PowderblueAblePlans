using System;

class Program {

    static void Main(string[] args)
  {
      Console.WriteLine("Please enter your message:");
      string userMessage = Console.ReadLine();

      if (userMessage.Length <= 140)
      {
          Console.WriteLine("Your message is: Posted");
      }
      else
      {
          Console.WriteLine("Your message is: Rejected");
      }
  }
  }

  
    
    //Console.WriteLine("({0} + {1}) * {2} = {3}", x, y, z, total);
    //Console.WriteLine("The value of y is {0}", y);
    
    //string declareString = "Declared String";
    //Console.Write(declareString);

    //var fullName = ConcatName("Julia", "Kelly");
    //Console.WriteLine("Hello world! {0} is here and {1} likes cats", fullName, fullName);

