using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;

namespace Bcr.Bowling.Test
{
    [TestClass]
    public class FrameTest
    {
        [TestMethod]
        public void TestZeroFrame()
        {
            var frame = new Frame();

            Assert.AreEqual(0, frame.Score);
        }

        [TestMethod]
        public void TestOpenFrame()
        {
            var frame = new Frame();

            frame.Throw(1);
            Assert.IsFalse(frame.IsPrimaryThrowsDone);
            Assert.IsTrue(frame.WantsMoreThrows);
            frame.Throw(2);
            Assert.IsTrue(frame.IsPrimaryThrowsDone);
            Assert.IsFalse(frame.WantsMoreThrows);

            Assert.AreEqual(3, frame.Score);
        }

        [TestMethod]
        public void TestSpareFrame()
        {
            var frame = new Frame();

            frame.Throw(2);
            Assert.IsFalse(frame.IsPrimaryThrowsDone);
            Assert.IsTrue(frame.WantsMoreThrows);
            frame.Throw(8);
            Assert.IsTrue(frame.IsPrimaryThrowsDone);
            Assert.IsTrue(frame.WantsMoreThrows);
            frame.Throw(3);
            Assert.IsTrue(frame.IsPrimaryThrowsDone);
            Assert.IsFalse(frame.WantsMoreThrows);

            Assert.AreEqual(13, frame.Score);
        }
    }
}
