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
      Console.WriteLine(LetsStartNewGame.CalculateValue[1]);
    }
  }
}