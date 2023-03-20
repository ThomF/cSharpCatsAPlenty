namespace catsAPlenty.Services;

public class CatsService
{

  private readonly CatsRepository _repo;

  public CatsService(CatsRepository repo)
  {
    _repo = repo;
  }

  public List<Cat> GetAllCats()
  {
    return _repo.GetAllCats();
  }

  internal Cat AdoptCat(int id)
  {
    Cat cat = this.GetOneCat(id);
    cat.AdoptMe(); // just weirdness today
    return cat;
  }

  internal Cat CreateCat(Cat catData)
  {
    Cat cat = _repo.CreateCat(catData);
    return cat;
  }

  internal Cat GetOneCat(int id)
  {
    Cat cat = _repo.GetOneCat(id);
    if (cat == null) throw new Exception($"No cat at id:{id}");
    return cat;
  }

  internal string RemoveCat(int catId)
  {
    Cat cat = this.GetOneCat(catId);
    bool result = _repo.RemoveCat(catId);
    if (!result) throw new Exception("Didn't delete any cats for some reason.");
    return $"{cat.Name} was quite a handful and has been moved to a higher security facility.";
  }
}
