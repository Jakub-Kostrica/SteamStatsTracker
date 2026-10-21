using Microsoft.AspNetCore.Mvc;

namespace SteamStatsTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : Controller
    {

        public static string[] games = { "Warframe", "7 Days To Die", "Terraria", "R6", "Rocket League" };

        [HttpGet(Name = "GetGames")]
        public IActionResult GetGames()
        {
            string game = "Warframe";
            return Ok(games);
        }
    }
}
