using System;
using System.Collections.Generic;

namespace MarsRoverMoveApp
{
    public class MoveRover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }

        public MoveRover()
        {
            X = 0;
            Y = 0;
            Direction = char.MinValue;
        }

        public void MoveToRover(List<string> MaxLimit, List<char> Moves)
        {
            foreach (char move in Moves)
            {
                switch (move)
                {
                    case 'M':
                        SameDirectionMove();
                        break;
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    default:
                        break;
                }

                if (this.X < 0 || this.X > Convert.ToInt16(MaxLimit[0]) || this.Y < 0 || this.Y > Convert.ToInt16(MaxLimit[1]))
                    throw new Exception("Rover has exceeded the maximum limit it will discover");
            }
        }

        private void SameDirectionMove()
        {
            switch (Direction)
            {
                case 'E':
                    this.X += 1;
                    break;
                case 'W':
                    this.X -= 1;
                    break;
                case 'N':
                    this.Y += 1;
                    break;
                case 'S':
                    this.Y -= 1;
                    break;
                default:
                    break;
            }
        }

        private void RotateLeft()
        {
            switch (Direction)
            {
                case 'E':
                    this.Direction = 'N';
                    break;
                case 'W':
                    this.Direction = 'S';
                    break;
                case 'N':
                    this.Direction = 'W';
                    break;
                case 'S':
                    this.Direction = 'E';
                    break;
                default:
                    break;
            }
        }

        private void RotateRight()
        {
            switch (Direction)
            {
                case 'E':
                    this.Direction = 'S';
                    break;
                case 'W':
                    this.Direction = 'N';
                    break;
                case 'N':
                    this.Direction = 'E';
                    break;
                case 'S':
                    this.Direction = 'W';
                    break;
                default:
                    break;
            }
        }

        public string GetRoverPosition()
        {
            return string.Format("{0} {1} {2}", this.X, this.Y, this.Direction);
        }
    }
}
