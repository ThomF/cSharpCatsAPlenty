namespace catsAPlenty.Controllers;

[ApiController]
[Route("api/cats")]
public class CatsController : ControllerBase
{

  private readonly CatsService _catsService;

  public CatsController(CatsService catsService)
  {
    _catsService = catsService;
  }

  [HttpGet]
  // NOTE ok is for the action result, list is to define it's a collection of , Cat, which the inner data type
  public ActionResult<List<Cat>> GetAll()
  {
    try
    {
      return Ok(_catsService.GetAllCats());
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Cat> GetOneCat(int id)
  {
    try
    {
      Cat cat = _catsService.GetOneCat(id);
      return Ok(cat);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Cat> CreateCat([FromBody] Cat catData)
  {
    try
    {
      Cat cat = _catsService.CreateCat(catData);
      return Ok(cat);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{catId}")]
  public ActionResult<string> RemoveCat(int catId)
  {
    try
    {
      string message = _catsService.RemoveCat(catId);
      return Ok(message);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{id}/adopt")]
  public ActionResult<Cat> AdoptCat(int id)
  {
    try
    {
      Cat cat = _catsService.AdoptCat(id);
      return Ok(cat);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }


}
