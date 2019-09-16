using System;
using System.Linq;

namespace SafariVacation
{
  class Program
  {
    static void CreateData()
    {
      // 1. Reference the database
      var db = new SafariContext();

      // 2. Create a new movie
      var fox = new SeenAnimals
      {
        Species = "Camel",
        CountOfTimesSeen = 7,
        LocationOfLastSeen = "Desert"
      };
      db.SeenAnimal.Add(fox);
      // 3. Save the thing
      db.SaveChanges();
    }
    static void ReadData()
    {
      var db = new SafariContext();
      var animalSeen = db.SeenAnimal
      .Select(SeenAnimals => SeenAnimals.Species).Distinct();
      Console.WriteLine(animalSeen.Distinct());
    }
    static void UpdateData() { }
    static void DeleteData() { }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //CreateData();
      ReadData();
      //UpdateData();
      //DeleteData();
    }
  }
}
