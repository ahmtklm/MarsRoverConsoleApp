using MarsRoverConsoleApp.Services.Interfaces;

namespace MarsRoverConsoleApp.Services.Commands
{
    public class TurnLeftCommand : ICommand
    {
        IRover rover;

        public TurnLeftCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.TurnLeft();
        }
    }

}
