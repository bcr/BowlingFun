using System.Collections.Generic;
using System.Linq;

namespace Bcr.Bowling
{
    public class Game
    {
        public int Score { get; set; }

        private enum GameState
        {
            FirstBall,
            SecondBall,
            Spare,
        }

        public void Throw(IEnumerable<int> throws)
        {
            GameState state = GameState.FirstBall;
            int score = 0;

            foreach (var _throw in throws)
            {
                score += _throw;

                switch (state)
                {
                    case GameState.FirstBall:
                        state = GameState.SecondBall;
                        break;

                    case GameState.SecondBall:
                        Score += score;
                        state = (score == 10) ? GameState.Spare : GameState.FirstBall;
                        score = 0;
                        break;
                    
                    case GameState.Spare:
                        Score += score;
                        state = GameState.SecondBall;
                        break;
                }
            }
        }
    }
}