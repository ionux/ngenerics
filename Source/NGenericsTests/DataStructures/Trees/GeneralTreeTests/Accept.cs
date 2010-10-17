﻿using System;
using NGenerics.Patterns.Visitor;
using NGenerics.Tests.Util;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.GeneralTreeTests
{
    [TestFixture]
    public class Accept : GeneralTreeTest
    {

        [Test]
        public void Simple()
        {
            var generalTree = GetTestTree();

            var trackingVisitor = new TrackingVisitor<int>();
            generalTree.AcceptVisitor(trackingVisitor);

            Assert.AreEqual(trackingVisitor.TrackingList.Count, 7);

            Assert.IsTrue(trackingVisitor.TrackingList.Contains(5));
            Assert.IsTrue(trackingVisitor.TrackingList.Contains(2));
            Assert.IsTrue(trackingVisitor.TrackingList.Contains(3));
            Assert.IsTrue(trackingVisitor.TrackingList.Contains(1));
            Assert.IsTrue(trackingVisitor.TrackingList.Contains(9));
            Assert.IsTrue(trackingVisitor.TrackingList.Contains(12));
            Assert.IsTrue(trackingVisitor.TrackingList.Contains(13));
        }

        [Test]
        public void AcceptCompletedVisitor()
        {
            var generalTree = GetTestTree();

            var completedTrackingVisitor = new CompletedTrackingVisitor<int>();
            generalTree.AcceptVisitor(completedTrackingVisitor);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionNullVisitor()
        {
            var generalTree = GetTestTree();
            generalTree.AcceptVisitor(null);
        }

    }
}