using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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
            string favGame = "Warframe";

            GameData data = new GameData(favGame, games);

            Console.WriteLine(JsonSerializer.Serialize(data));
            
            return Ok(data);
        }
    }
}
