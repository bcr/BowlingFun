using System.Collections.Generic;

using System.Linq;

namespace Bcr.Bowling
{
    public class Game
    {
        public int Score { get { return frames.Sum(frame => frame.Score); } }

        private List<Frame> frames = new List<Frame> { new Frame() };

        public void Throw(IEnumerable<int> throws)
        {
            foreach (var _throw in throws)
            {
                bool lastFramePrimaryThrowsDone = false;

                foreach (var frame in frames)
                {
                    if (frame.WantsMoreThrows)
                    {
                        frame.Throw(_throw);
                    }
                    lastFramePrimaryThrowsDone = frame.IsPrimaryThrowsDone;
                }

                if (lastFramePrimaryThrowsDone)
                {
                    frames.Add(new Frame());
                }
            }
        }
    }
}