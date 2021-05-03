using System;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number:");
      string userInput = Console.ReadLine();
      try
      {
        int intInput = int.Parse(userInput);
      }
      catch (FormatException e)
      {
        Console.WriteLine("Hey, that wasn't a number!");
        Main();
      }
    }
  }
}