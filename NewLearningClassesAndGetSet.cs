namespace Gamer.Testing
{
public class Game
{
  // Private fields
  public string Age { get; set; }
  public int Multiplier { get; set; }
  public int Divider { get; set; }
  //public int ActualValue { get; set; }
  private Dictionary<int, Action> CalculateValue { get; set; }

  // Constructor
  public Game(int age, int multiplier, int divider)
  {
    Age = age;
    Multiplier = multiplier;
    Divider = divider;
    //ActualValue = 0;
    CalculateValue = new Dictionary<int, Action>() { {1, () => AgeOnMercury()}, {2, () => AgeOnJupiter() } };
  }



  public int AgeOnMercury(int Age, int Multiplier)
  {
    return Age*Multiplier;
  }

  public int AgeOnJupiter(int Age, int Divider)
  {
    return Age*Divider;
  }

  
  
  

  
}
}
