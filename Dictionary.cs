namespace CarsIOwned
{
  public class Program
  {
    public static void Main()
    {

      Dictionary<int, string> NewVenture = new Dicitionary<int, string>();

      NewVenture.Add(1, "suzuki");
      NewVenture.Add(2, "Santro");
      NewVenture.Add(3, "Geo Prism");
      NewVenture.Add(4, "Honda Accor");
      NewVenture.Add(5, "Dodge Caravan");
      NewVenture.Add(6, "Toyota Corolla");
      NewVenture.Add(7, "Nissan Quest");
      NewVenture.Add(8, "Nissan Sentra");

      for (int i=0; i<NewVenture.Count; i=i+1)
      {
        Console.WriteLine(NewVenture[i]);
      }

      NewVenture.Add(9, "Honda N Wagon");
      NewVenture.Add(10, "Kiya Picanto");

      Console.WriteLine ("here is the Dictionay again with two more added");

      for (int i=0; i<NewVenture.Count; i=i+1)
      {
        Console.WriteLine(NewVenture[i]);
      }


      for (int i=0; i<4; i=i+1)
      {
        NewVenture.Remove(NewVenture[i]);
      }

      Console.WriteLine("Here is the Dictionary with first four removed");

      for (int i=0; i<NewVenture.Count; i=i+1)
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



