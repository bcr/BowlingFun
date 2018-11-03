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

        [TestMethod]
        public void TestOpenFrames()
        {
            var game = new Game();

            // A little better than our gutterball friend. Hits a pin.
            // 20 throws of one (two for each frame, ten frames)

            // Finally an opportunity to score something!

            game.Throw(Enumerable.Repeat(1, 20));
            Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void TestSpare()
        {
            var game = new Game();

            // See if we can score a spare.
            // First two throws total ten, third throw is added to the total

            game.Throw(new int[] { 2, 8, 3 });
            Assert.AreEqual(13, game.Score);
        }
    }
}
