using System.Collections.Generic;
using Xunit;

namespace MarsRoverMoveAppTest
{
    public class MarsRoverMoveTheoryData : TheoryData<MarsRoverMoveParameters>
    {
        public MarsRoverMoveTheoryData()
        {
            Add(new MarsRoverMoveParameters
            {
                X = 1,
                Y = 2,
                Direction = 'N',
                MaxLimit = new List<string> { "5", "5" },
                Moves = new List<char> { 'L', 'M', 'L', 'M', 'L', 'M', 'L', 'M', 'M' },
                ExpectedOutput = "1 3 N"
            });
            Add(new MarsRoverMoveParameters
            {
                X = 3,
                Y = 3,
                Direction = 'E',
                MaxLimit = new List<string> { "5", "5" },
                Moves = new List<char> { 'M', 'M', 'R', 'M', 'M', 'R', 'M', 'R', 'R', 'M' },
                ExpectedOutput = "5 1 E"
            });
        }
    }
}
