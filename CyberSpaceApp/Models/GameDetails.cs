using System.Collections.Generic;

namespace CyberSpaceApp.Models
{
    public class GameDetails
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        
    }

    public static class SelectedGamesStorage
    {
        public static List<GameDetails> SelectedGames { get; } = new List<GameDetails>();
    }
}

