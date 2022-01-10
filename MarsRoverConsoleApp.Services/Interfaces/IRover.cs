using System.Collections.Generic;

namespace MarsRoverConsoleApp.Services.Interfaces
{
    public interface IRover
    {
        IRoverPosition CurrentPosition { get; }
        IPlateauGrid PlateauGrid { get; set; }
        IList<ICommand> Commands { get; set; }
        bool Initialize(string roverPositionInput);
        void CommandParse(string roverCommandInput);
        void Move(); // harekete geç
        void TurnRight(); //sağa dön
        void TurnLeft();  // sola dön
    }
}
