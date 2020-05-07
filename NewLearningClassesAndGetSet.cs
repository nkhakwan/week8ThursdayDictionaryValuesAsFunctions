using System;
using System.Collections.Generic;

namespace Gamer.Testing
{
public class Game
{
  // Private fields
  public int Age { get; set; }
  public int Multiplier { get; set; }
  public int Divider { get; set; }
  //public int ActualValue { get; set; }
  public Dictionary<int, Func<int>> CalculateValue { get; set; }

  // Constructor
  public Game(int age, int multiplier, int divider)
  {
    Age = age;
    Multiplier = multiplier;
    Divider = divider;
    //ActualValue = 0;
    CalculateValue = new Dictionary<int, Func<int>>() { {1, () => AgeOnMercury( Age,  Multiplier)}, {2, () => AgeOnJupiter (Age,  Divider) } };
  }



  public int AgeOnMercury(int Age, int Multiplier)
  {
    Console.WriteLine("we are in the first function");
    return Age*Multiplier;
  }


  public int AgeOnJupiter(int Age, int Divider)
  {
    return Age/Divider;
  }

  
  
  

  
}
}
