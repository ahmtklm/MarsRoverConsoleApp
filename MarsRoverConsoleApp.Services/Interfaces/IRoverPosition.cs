using MarsRoverConsoleApp.Common.Enums;

namespace MarsRoverConsoleApp.Services.Interfaces
{
    public interface IRoverPosition
    {
        int CoordinateX { get; set; }
        int CoordinateY { get; set; }
        EnumRoverDirection Direction { get; set; }
    }
}
