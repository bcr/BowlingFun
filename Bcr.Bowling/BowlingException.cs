using System;

namespace Bcr.Bowling
{
    public class BowlingException : Exception
    {
        public BowlingException() : base() {}
        public BowlingException(String message) : base(message) {}
        public BowlingException(String message, Exception inner) : base(message, inner) {}
    }
}