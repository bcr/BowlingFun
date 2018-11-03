using System.Collections.Generic;
using System.Linq;

namespace Bcr.Bowling
{
    public class Game
    {
        public int Score { get; set; }

        public void Throw(IEnumerable<int> throws)
        {
            Score = throws.Sum();
        }
    }
}