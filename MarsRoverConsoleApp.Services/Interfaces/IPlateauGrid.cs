using System.Collections.Generic;

namespace MarsRoverConsoleApp.Services.Interfaces
{
    public interface IPlateauGrid
    {
        int GridX { get; set; }
        int GridY { get; set; }
        bool CheckInit { get; }
        bool Initialize(string gridSizeInput);
        IList<IRover> Rovers { get; set; }
    }
}
