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
        Species = "Alligator",
        CountOfTimesSeen = 3,
        LocationOfLastSeen = "Swamp"
      };
      db.SeenAnimal.Add(fox);
      // 3. Save the thing
      db.SaveChanges();
    }
    static void ReadData()
    {
      var db = new SafariContext();
      var animalSeen = db.SeenAnimal
      .Where(SeenAnimals => SeenAnimals.LocationOfLastSeen == "Jungle")
      .Select(SeenAnimals => SeenAnimals.Species);
      foreach (var animal in animalSeen)
      {
        Console.WriteLine(animal);
      }
    }
    static void UpdateData()
    {
      var db = new SafariContext();
      var animalToUpdate = db.SeenAnimal.FirstOrDefault(SeenAnimals => SeenAnimals.Species == "Tiger");
      animalToUpdate.CountOfTimesSeen = 14;
      animalToUpdate.LocationOfLastSeen = "Grasslands";
      db.SaveChanges();
    }
    static void DeleteData()
    {
      var db = new SafariContext();
      var animalToDelete = db.SeenAnimal
      .Where(SeenAnimals => SeenAnimals.LocationOfLastSeen == "Desert")
      .Select(SeenAnimals => SeenAnimals);
      foreach (var animal in animalToDelete)
      {
        db.SeenAnimal.Remove(animal);
      }
      db.SaveChanges();
    }

    static void addData()
    {
      var db = new SafariContext();
      var animalSeen = db.SeenAnimal.Sum(SeenAnimals => SeenAnimals.CountOfTimesSeen);
      Console.WriteLine("Number of animals seen: " + animalSeen);
    }

    static void readCountOfAnimals()
    {
      var db = new SafariContext();
      var animalSeen = db.SeenAnimal
      .Where(SeenAnimals => SeenAnimals.Species == "Bear" || SeenAnimals.Species == "Lion" || SeenAnimals.Species == "Tiger")
      .Select(SeenAnimals => SeenAnimals.CountOfTimesSeen);
      foreach (var animal in animalSeen)
      {
        Console.WriteLine(animal);
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //CreateData();
      //ReadData();
      //UpdateData();
      //DeleteData();
      //addData();
      readCountOfAnimals();
    }
  }
}
