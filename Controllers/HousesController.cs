namespace gregslist_csharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{

  public HousesController(HousesService housesService, Auth0Provider auth0Provider)
  {
    _housesService = housesService;
    _auth0Provider = auth0Provider;
  }

  private readonly HousesService _housesService;
  private readonly Auth0Provider _auth0Provider;


  [HttpGet]
  public ActionResult<List<House>> GetAllHouses()
  {
    try
    {
      List<House> houses = _housesService.GetAllHouses();
      return Ok(houses);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}