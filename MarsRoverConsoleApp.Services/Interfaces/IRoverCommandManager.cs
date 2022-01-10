namespace MarsRoverConsoleApp.Services.Interfaces
{
    public interface IRoverCommandManager
    {
        IRover Rover { get; set; }
        void AddCommand(ICommand command);
        void ProcessCommands();
    }
}
