namespace BlazorDemo.Web.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController(PizzaStoreContext db) : Controller
{
    private readonly PizzaStoreContext _db = db;

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecialsAsync()
    {
        return await _db.Specials.ToListAsync();
    }
}