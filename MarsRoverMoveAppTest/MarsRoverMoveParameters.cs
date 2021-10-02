using System.Collections.Generic;

namespace MarsRoverMoveAppTest
{
    public class MarsRoverMoveParameters
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public List<string> MaxLimit { get; set; }
        public List<char> Moves { get; set; }
        public string ExpectedOutput { get; set; }
    }
}