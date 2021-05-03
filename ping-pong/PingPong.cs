using System;

namespace PingPong
{
  public class Reporter
  {
    public static void Report(int upTo)
    {
      for (int idx = 0; idx <= upTo; idx++)
      {
        // 16 % 8 = 0
        if (idx % 3 == 0)
        {
          Console.WriteLine("Ping");
        }
      }

    }
  }
}