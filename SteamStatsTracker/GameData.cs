namespace SteamStatsTracker
{
    public class GameData
    {
        public string favouriteGame { get; set; }
        public string[] gameLibrary { get; set; }

        public GameData(string favGame, string[] game_library)
        {
            favouriteGame = favGame;
            gameLibrary = game_library;
        }
    }
}
