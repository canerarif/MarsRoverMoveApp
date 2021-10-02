using MarsRoverMoveApp;
using Xunit;

namespace MarsRoverMoveAppTest
{
    public class MarsRoverMoveTest
    {
        [Theory, ClassData(typeof(MarsRoverMoveTheoryData))]
        public void MoveTest(MarsRoverMoveParameters parameter)
        {
            MoveRover moveRover = new MoveRover()
            {
                X = parameter.X,
                Y = parameter.Y,
                Direction = parameter.Direction
            };

            moveRover.MoveToRover(parameter.MaxLimit, parameter.Moves);

            var actualOutput = moveRover.GetRoverPosition();
            var expectedOutput = parameter.ExpectedOutput;

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
