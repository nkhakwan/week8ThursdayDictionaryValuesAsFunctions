using System;
using System.Collections.Generic;

namespace CarsIOwned
{
  public class Program
  {
    public static void Main()
    {

      Dictionary<int, string> NewVenture = new Dictionary<int, string>();

      NewVenture.Add(1, "suzuki");
      NewVenture.Add(2, "Santro");
      NewVenture.Add(3, "Geo Prism");
      NewVenture.Add(4, "Honda Accor");
      NewVenture.Add(5, "Dodge Caravan");
      NewVenture.Add(6, "Toyota Corolla");
      NewVenture.Add(7, "Nissan Quest");
      NewVenture.Add(8, "Nissan Sentra");
       List<int> MyKeys = new List<int>(NewVenture.Keys);
      for (int i=1; i<MyKeys.Count; i=i+1)
      {
        Console.WriteLine("here is the list of keys" + " " +MyKeys[i]);

      }


      for (int i=1; i<NewVenture.Count+1; i=i+1)
      {
        Console.WriteLine(NewVenture[i]);
      }

      NewVenture.Add(9, "Honda N Wagon");
      NewVenture.Add(10, "Kiya Picanto");

      Console.WriteLine ("here is the Dictionay again with two more added");

      for (int i=1; i<NewVenture.Count+1; i=i+1)
      {
        Console.WriteLine(NewVenture[i]);
      }


      for (int i=1; i<4; i=i+1)
      {
        NewVenture.Remove(i);
      }

      Console.WriteLine("Here is the Dictionary with first four removed");

      for (int i=5; i<NewVenture.Count+1; i=i+1)
      {
        Console.WriteLine(NewVenture[i]);
      }

      if (NewVenture.ContainsKey(6))
      {
        Console.WriteLine("here is the value for key6:" + NewVenture[6]);
      }

    }
  }
}














