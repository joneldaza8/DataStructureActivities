using System;
using Week3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week3.Test
{
    [TestClass]
    public class MyStackTest
    {

        [TestMethod]
        public void TestPush()
        {
            // Arrange
            IMyStack myStack = new MyStack();

            // Act
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            // Assert
            Assert.AreEqual(myStack.Top(), 4);
        }

        [TestMethod]
        public void TestPop()
        {
            // Arrange
            IMyStack myStack = new MyStack();

            // Act
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            var toppedStack = myStack.Pop();

            // Assert
            Assert.AreEqual(toppedStack.Top(), 3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))] // Assert
        public void TestPop_Should_ThrowException_When_PoppedEmpty()
        {
            // Arrange
            MyStack myStack = new MyStack();

            // Act
            var toppedStack = myStack.Pop();
        }

        [TestMethod]
        public void TestIsEmpty()
        {
            // Arrange
            MyStack emptyStack = new MyStack();

            MyStack notEmptyStack = new MyStack();
            
            // Act
            notEmptyStack.Push(1);

            // Assert
            Assert.IsTrue(emptyStack.IsEmpty());
            Assert.IsFalse(notEmptyStack.IsEmpty());
        }

        [TestMethod]
        public void TestEmpty()
        {
            // Arrange
            MyStack myStack = new MyStack();
            
            // Act
            myStack.Push(1);
            myStack.Empty();

            // Assert
            Assert.IsTrue(myStack.IsEmpty());
        }

        

    }
}