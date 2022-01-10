using MarsRoverConsoleApp.Services.Interfaces;
using System.Windows.Input;
using ICommand = MarsRoverConsoleApp.Services.Interfaces.ICommand;

namespace MarsRoverConsoleApp.Services.Commands
{
    public class TurnRightCommand : ICommand
    {
        IRover rover;

        public TurnRightCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.TurnRight();
        }
    }
}
