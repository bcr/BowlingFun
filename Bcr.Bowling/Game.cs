using System.Collections.Generic;

using System.Linq;

namespace Bcr.Bowling
{
    public class Game
    {
        public int Score
        {
            get
            {
                int finalScore = 0;
                int index = 0;
                int frameNumber = 1;

                while ((index < throwIndex) && (frameNumber <= 10))
                {
                    int nextTwoBallsTotal = (finalThrows[index] + finalThrows[index + 1]);

                    finalScore += nextTwoBallsTotal;

                    if (finalThrows[index] == 10)
                    {
                        // Steerike
                        finalScore += finalThrows[index + 2];
                        index += 1;
                    }
                    else
                    {
                        finalScore += (nextTwoBallsTotal == 10) ? finalThrows[index + 2] : 0;
                        index += 2;
                    }

                    ++frameNumber;
                }
                return finalScore;
            }
        }

        // Good ole magic 21 throws. If you throw all zeroes for the first
        // nine frames, that's 18 throws. In the tenth if you suddenly get a
        // strike, that's 19 throws, plus two more throws to close the tenth
        // frame, a total of 21.
        private int[] finalThrows = new int[21];
        private int throwIndex = 0;

        public void Throw(IEnumerable<int> throws)
        {
            foreach (var _throw in throws)
            {
                finalThrows[throwIndex++] = _throw;
            }
        }
    }
}