using MarsRoverConsoleApp.Common.Enums;
using MarsRoverConsoleApp.Services.Interfaces;

namespace MarsRoverConsoleApp.Services.Implemantations
{
    public class RoverPosition : IRoverPosition
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public EnumRoverDirection Direction { get; set; }

        public RoverPosition(EnumRoverDirection direction = EnumRoverDirection.N,int coordinateX = 0,int coordinateY = 0)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.Direction = direction;
        }
    }
}
