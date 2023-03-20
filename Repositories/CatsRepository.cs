namespace catsAPlenty.Repositories;

public class CatsRepository
{
  private List<Cat> dbCats = new List<Cat>(); // were pretending we have a db here

  public CatsRepository()
  {
    dbCats.Add(new Cat("Winston", 8, "Grey", 9, 1));
    dbCats.Add(new Cat("Furgeson", 12, "Orange", 7, 2));
    dbCats.Add(new Cat("Bad Kitty", 3, "Striped", 9, 3));
  }

  internal Cat CreateCat(Cat catData)
  {
    catData.Id = dbCats[dbCats.Count - 1].Id + 1; // weird logic to fake unique ids
    dbCats.Add(new Cat(catData.Name, catData.Age, catData.Color, catData.Lives, catData.Id));
    return catData;
  }

  internal List<Cat> GetAllCats()
  {
    return dbCats;
  }

  internal Cat GetOneCat(int id)
  {
    Cat cat = dbCats.Find(cat => cat.Id == id);
    return cat;
  }

  internal bool RemoveCat(int catId)
  {
    int count = dbCats.RemoveAll(cat => cat.Id == catId);
    return count > 0;
  }
}
