using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;

namespace Bcr.Bowling.Test
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestZeroGame()
        {
            var game = new Game();

            Assert.AreEqual(0, game.Score);
        }

        [TestMethod]
        public void TestGutterballs()
        {
            var game = new Game();

            // Man, this fine player needs those bumpers in the gutters
            // 20 throws of zero (two for each frame, ten frames)

            game.Throw(Enumerable.Repeat(0, 20));
            Assert.AreEqual(0, game.Score);
        }
    }
}
