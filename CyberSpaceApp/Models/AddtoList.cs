using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSpaceApp.Models
{
    internal class AddtoList
    {
        // Model class for GamesTable
        public class Game
        {
            public int GameID { get; set; }
            public string GameName { get; set; }
            
        }

        // Model class for GameSpecsTable
        public class GameSpec
        {
            public int GameSpecID { get; set; }
            public int GameID { get; set; }
            public string SpecsColumn { get; set; }
            
        }

    }
}
