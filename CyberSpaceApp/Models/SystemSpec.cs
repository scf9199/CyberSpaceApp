using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSpaceApp.Models
{
    internal class SystemSpec
    {
    }
}
public class SystemSpec
{
    public int SpecID { get; set; } // Unique identifier for the system specification
    public int GameID { get; set; } // ID of the associated game
    public int RAMRequirement { get; set; } // Minimum RAM required in GB
    public string CPURequirement { get; set; } // Minimum CPU required
    public string GPURequirement { get; set; } // Minimum GPU required
    public string StorageRequirement { get; set; } // Minimum storage requirement (SSD/HDD)
}


public class Game
{
    public int GameID { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
}

