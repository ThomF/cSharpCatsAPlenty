namespace catsAPlenty.Models;

public class Cat
{
  public Cat(string name, int age, string color, int lives, int id)
  {
    Name = name;
    Age = age;
    Color = color;
    Lives = lives;
    Id = id;
  }

  public int Id { get; set; }
  public string Name { get; set; }
  public int Age { get; set; }
  public string Color { get; set; }
  public int Lives { get; set; }
  public bool Adopted { get; private set; } = false;

  public void AdoptMe()
  {
    this.Adopted = true;
  }
}
