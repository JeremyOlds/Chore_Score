

namespace Chore_Score.Controllers;

[ApiController]

public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;

    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }

[HttpGet]
public ActionResult<List<Chore>> GetChores()
{
    try
    {
        List<Chore> chores = _choresService.GetChores();
        return Ok(chores);
    }
    catch (Exception e)
    {
        
        return BadRequest(e.Message)
    }
}


}
