namespace Bcr.Bowling
{
    public class Frame
    {
        public int Score { get; set; }
        public bool IsPrimaryThrowsDone { get; set; }
        public bool WantsMoreThrows { get; set; } = true;

        private enum FrameState
        {
            FirstBall,
            SecondBall,
        }

        private FrameState state = FrameState.FirstBall;

        public void Throw(int _throw)
        {
            Score += _throw;
            switch (state)
            {
                case FrameState.FirstBall:
                    state = FrameState.SecondBall;
                    break;
                case FrameState.SecondBall:
                    WantsMoreThrows = false;
                    IsPrimaryThrowsDone = true;
                    break;
            }
        }
    }
}