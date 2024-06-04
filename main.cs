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

  

