using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
