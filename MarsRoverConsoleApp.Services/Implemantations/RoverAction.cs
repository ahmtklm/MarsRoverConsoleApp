using MarsRoverConsoleApp.Common.Enums;
using MarsRoverConsoleApp.Services.Interfaces;
using System;

namespace MarsRoverConsoleApp.Services.Implemantations
{
    public class RoverAction
    {
        public static IRoverPosition Move(IRoverPosition roverPosition)
        {
            IRoverPosition currentRoverPosition = roverPosition;

            switch (roverPosition.Direction)
            {
                case EnumRoverDirection.N:
                    currentRoverPosition = new RoverPosition(roverPosition.Direction, roverPosition.CoordinateX, roverPosition.CoordinateY + 1);
                    break;
                case EnumRoverDirection.S:
                    currentRoverPosition = new RoverPosition(roverPosition.Direction, roverPosition.CoordinateX, roverPosition.CoordinateY - 1);
                    break;
                case EnumRoverDirection.W:
                    currentRoverPosition = new RoverPosition(roverPosition.Direction, roverPosition.CoordinateX - 1, roverPosition.CoordinateY);
                    break;
                case EnumRoverDirection.E:
                    currentRoverPosition = new RoverPosition(roverPosition.Direction, roverPosition.CoordinateX + 1, roverPosition.CoordinateY);
                    break;
                default:
                    throw new InvalidOperationException();
            }

            return currentRoverPosition;
        }

        public static EnumRoverDirection TurnRight(EnumRoverDirection roverDirection)
        {
            EnumRoverDirection currentRoverDirection = roverDirection;

            switch (roverDirection)
            {
                case EnumRoverDirection.N:
                    currentRoverDirection = EnumRoverDirection.E;
                    break;
                case EnumRoverDirection.E:
                    currentRoverDirection = EnumRoverDirection.S;
                    break;
                case EnumRoverDirection.S:
                    currentRoverDirection = EnumRoverDirection.W;
                    break;
                case EnumRoverDirection.W:
                    currentRoverDirection = EnumRoverDirection.N;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return currentRoverDirection;
        }

        public static EnumRoverDirection TurnLeft(EnumRoverDirection roverDirection)
        {
            EnumRoverDirection currentRoverDirection = roverDirection;

            switch (roverDirection)
            {
                case EnumRoverDirection.N:
                    currentRoverDirection = EnumRoverDirection.W;
                    break;
                case EnumRoverDirection.E:
                    currentRoverDirection = EnumRoverDirection.N;
                    break;
                case EnumRoverDirection.S:
                    currentRoverDirection = EnumRoverDirection.E;
                    break;
                case EnumRoverDirection.W:
                    currentRoverDirection = EnumRoverDirection.S;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return currentRoverDirection;
        }
    }
}
