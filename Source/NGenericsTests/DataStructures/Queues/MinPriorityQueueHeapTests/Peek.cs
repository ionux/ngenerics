﻿using NGenerics.DataStructures.Queues;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.MinPriorityQueueHeapTests
{
    [TestFixture]
    public class Peek : MinPriorityQueueTest
    {
        [Test]
        public void Simple()
        {
            var priorityQueue = new PriorityQueue<string, int>(PriorityQueueType.Minimum);

            priorityQueue.Enqueue("g", 6);
            Assert.AreEqual(priorityQueue.Peek(), "g");

            priorityQueue.Enqueue("h", 5);
            Assert.AreEqual(priorityQueue.Peek(), "h");

            priorityQueue.Enqueue("i", 7);
            Assert.AreEqual(priorityQueue.Peek(), "h");
        }


        [Test]
        public void SimpleWithPriority()
        {
            var priorityQueue = new PriorityQueue<string, int>(PriorityQueueType.Minimum);

            int priority;

            priorityQueue.Enqueue("g", 6);

            var item = priorityQueue.Peek(out priority);

            Assert.AreEqual(item, "g");
            Assert.AreEqual(priority, 6);
            Assert.AreEqual(priorityQueue.Count, 1);

            priorityQueue.Enqueue("h", 5);

            item = priorityQueue.Peek(out priority);

            Assert.AreEqual(item, "h");
            Assert.AreEqual(priority, 5);
            Assert.AreEqual(priorityQueue.Count, 2);

            priorityQueue.Enqueue("i", 7);

            item = priorityQueue.Peek(out priority);

            Assert.AreEqual(item, "h");
            Assert.AreEqual(priority, 5);
            Assert.AreEqual(priorityQueue.Count, 3);
        }
    }
}