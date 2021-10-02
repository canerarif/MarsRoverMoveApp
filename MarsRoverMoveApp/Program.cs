using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverMoveApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> MaxLimit = Console.ReadLine().Trim().Split(' ').ToList();
            while (true)
            {
                List<string> BeginPosition = Console.ReadLine().Trim().Split(' ').ToList();
                List<char> Moves = Console.ReadLine().Trim().ToList();

                Exception exc = ValidateEnteredValues.Validate(MaxLimit, BeginPosition);
                if (exc != null)
                    Console.WriteLine(exc);

                try
                {
                    MoveRover moveRover = new MoveRover();
                    moveRover.X = Convert.ToInt16(BeginPosition[0]);
                    moveRover.Y = Convert.ToInt16(BeginPosition[1]);
                    moveRover.Direction = Convert.ToChar(BeginPosition[2]);

                    moveRover.MoveToRover(MaxLimit, Moves);

                    string RoverCurrentPosition = moveRover.GetRoverPosition();
                    Console.WriteLine(RoverCurrentPosition);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
