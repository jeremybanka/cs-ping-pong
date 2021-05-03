using System;

namespace PingPong
{
  public class Reporter
  {
    public static void Report(int upTo)
    {
      for (int idx = 0; idx <= upTo; idx++)
      {
        bool isDivisibleByThree = idx % 3 == 0;
        bool isDivisibleByFive = idx % 5 == 0;
        if (isDivisibleByThree && isDivisibleByFive)
        {
          Console.WriteLine("Ping-Pong");
        }
        else if (isDivisibleByThree)
        {
          Console.WriteLine("Ping");
        }
        else if (isDivisibleByFive)
        {
          Console.WriteLine("Pong");
        }
        else
        {
          Console.WriteLine(idx);
        }
      }
    }
  }
}