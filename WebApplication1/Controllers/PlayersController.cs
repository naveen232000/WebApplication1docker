using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        List<Players> players = new List<Players> {
    new Players(){Id=1,Name="msd",Avg=20,Team="csk"},
    new Players(){Id=2,Name="virat",Avg=45,Team="rcb"},
    new Players(){Id=3,Name="rohit",Avg=42,Team="mi"},
    new Players(){Id=4,Name="sachin",Avg=48,Team="mi"},
    new Players(){Id=5,Name="abd",Avg=39,Team="rcb"}
};
        [HttpGet]
        public ActionResult<IEnumerable<Players>> Get() { return players; }
    }
}
