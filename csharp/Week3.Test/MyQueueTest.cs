using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week3.Test
{
    [TestClass]
    public class MyQueueTest
    {
        [TestMethod]
        public void TestEnqueue()
        {
            // Arrange
            MyQueue queue = new MyQueue();

            // Act
            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            // Assert
            Assert.AreEqual(queue.Top(),5);
        }

        [TestMethod]
        public void TestDequeue()
        {
            // Arrange
            MyQueue queue = new MyQueue();

            // Act
            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            MyQueue dequeued = queue.Dequeue();
            // Assert
            Assert.AreEqual(dequeued.Top(),2);
        }

        [TestMethod]
        public void TestTop()
        {
            // Arrange
            MyQueue queue = new MyQueue();

            // Act
            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            // Assert
            Assert.AreEqual(queue.Top(),5);
        }

        [TestMethod]
        public void TestEmpty()
        {
            // Arrange
            MyQueue emptyQueue = new MyQueue();

            MyQueue queue = new MyQueue();

            // Act
            queue.Enqueue(5);
            
            // Assert
            Assert.IsFalse(queue.IsEmpty());
            Assert.IsTrue(emptyQueue.IsEmpty());
        }
    }
}