using System;
using System.Collections.Generic;
using Gamer.Testing;

namespace Gamer
{
  public class Program
  {
    public static void Main()
    {
      Game LetsStartNewGame = new Game(67 , 3 , 6);
      Console.WriteLine(LetsStartNewGame.CalculateValue[1].Invoke());
      Console.WriteLine(LetsStartNewGame.CalculateValue[2].Invoke());
    }
  }
}
// youre welcome