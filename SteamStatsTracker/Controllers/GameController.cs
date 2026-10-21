using Microsoft.AspNetCore.Mvc;

namespace SteamStatsTracker.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GameController : ControllerBase
    {
        public static string[] games = { "Warframe", "7 Days To Die", "Terraria", "R6", "Rocket League" };

        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGames")]
        public static string[] GetGames()
        {
            return games;
        }
    }
}
