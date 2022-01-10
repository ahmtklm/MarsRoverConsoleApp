using MarsRoverConsoleApp.Services.Commands;
using MarsRoverConsoleApp.Services.Implemantations;
using MarsRoverConsoleApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRoverConsoleApp.Services
{
    public class DI
    {
        public static ServiceProvider Configure()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ICommand, TurnLeftCommand>();
            services.AddTransient<ICommand, TurnRightCommand>();
            services.AddTransient<ICommand, MoveCommand>();
            services.AddTransient<IRoverCommandManager, RoverCommandManager>();
            services.AddTransient<IRoverPosition, RoverPosition>();
            services.AddTransient<IRover, Rover>();
            services.AddTransient<IPlateauGrid, PlateauGrid>();

            return services.BuildServiceProvider();
        }
    }
}
