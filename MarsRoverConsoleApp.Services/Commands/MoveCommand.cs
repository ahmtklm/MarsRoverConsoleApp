using MarsRoverConsoleApp.Services.Interfaces;
using ICommand = MarsRoverConsoleApp.Services.Interfaces.ICommand;

namespace MarsRoverConsoleApp.Services.Commands
{
    public class MoveCommand : ICommand
    {
        IRover rover;

        public MoveCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.Move();
        }
    }
}
