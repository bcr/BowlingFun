using System;

using Bcr.Bowling;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bcr.Bowling.Test
{
    [TestClass]
    public class BowlingExceptionTest
    {
        public static void IsValidExceptionClass(Type type)
        {
            // Derives from Exception
            // https://stackoverflow.com/questions/2742276/how-do-i-check-if-a-type-is-a-subtype-or-the-type-of-an-object

            Assert.IsTrue(type.IsSubclassOf(typeof(Exception)), "Class does not derive from Exception");

            // Has required constructors
            // https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions

            // No arguments
            // https://stackoverflow.com/questions/142356/most-efficient-way-to-get-default-constructor-of-a-type
            Assert.IsNotNull(type.GetConstructor(Type.EmptyTypes), "Class does not implement empty constructor");

            // string message
            Assert.IsNotNull(type.GetConstructor(new Type[] { typeof(string)}), "Class does not implement (string) constructor");

            // string message, Exception inner
            Assert.IsNotNull(type.GetConstructor(new Type[] { typeof(string), typeof(Exception)}), "Class does not implement (string, Exception) constructor");
        }

        private class NotDerivedFromException
        {
            public NotDerivedFromException() {}
            public NotDerivedFromException(string message) {}
            public NotDerivedFromException(string message, Exception inner) {}
        }

        [TestMethod]
        public void TestExceptionClassNotDerivedFromException()
        {
            Assert.ThrowsException<AssertFailedException>(() => IsValidExceptionClass(typeof(NotDerivedFromException)));
        }

        private class MissingDefaultConstructor : Exception
        {
//            public MissingDefaultConstructor() {}
            public MissingDefaultConstructor(string message) {}
            public MissingDefaultConstructor(string message, Exception inner) {}
        }

        [TestMethod]
        public void TestExceptionClassMissingDefaultConstructor()
        {
            Assert.ThrowsException<AssertFailedException>(() => IsValidExceptionClass(typeof(MissingDefaultConstructor)));
        }

        private class MissingStringConstructor : Exception
        {
            public MissingStringConstructor() {}
//            public MissingStringConstructor(string message) {}
            public MissingStringConstructor(string message, Exception inner) {}
        }

        [TestMethod]
        public void TestExceptionClassMissingStringConstructor()
        {
            Assert.ThrowsException<AssertFailedException>(() => IsValidExceptionClass(typeof(MissingStringConstructor)));
        }

        private class MissingStringAndExceptionConstructor : Exception
        {
            public MissingStringAndExceptionConstructor() {}
            public MissingStringAndExceptionConstructor(string message) {}
//            public MissingStringAndExceptionConstructor(string message, Exception inner) {}
        }

        [TestMethod]
        public void TestExceptionClassMissingStringAndExceptionConstructor()
        {
            Assert.ThrowsException<AssertFailedException>(() => IsValidExceptionClass(typeof(MissingStringAndExceptionConstructor)));
        }

        [TestMethod]
        public void TestBowlingExceptionIsValidExceptionClass()
        {
            IsValidExceptionClass(typeof(BowlingException));
        }
    }
}
