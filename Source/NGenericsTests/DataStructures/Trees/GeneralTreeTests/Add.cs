﻿using NGenerics.DataStructures.Trees;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.GeneralTreeTests
{
    [TestFixture]
    public class Add : GeneralTreeTest
    {

        [Test]
        public void Simple()
        {
            var root = new GeneralTree<int>(5);

            var child1 = new GeneralTree<int>(2);
            var child2 = new GeneralTree<int>(3);

            root.Add(child1);
            root.Add(child2);

            Assert.AreEqual(child1.Parent, root);
            Assert.AreEqual(child2.Parent, root);

            Assert.AreEqual(root.Count, 2);
            Assert.AreEqual(root.Degree, 2);

            Assert.AreEqual(root.GetChild(0), child1);
            Assert.AreEqual(root.GetChild(0).Data, child1.Data);

            Assert.AreEqual(root.GetChild(1).Data, child2.Data);
            Assert.AreEqual(root.GetChild(1), child2);

            root = new GeneralTree<int>(5)
                       {
                           2,
                           3
                       };

            Assert.AreEqual(root.GetChild(0).Data, child1.Data);
            Assert.AreEqual(root.GetChild(1).Data, child2.Data);

            Assert.AreEqual(root.GetChild(0).Parent, root);
            Assert.AreEqual(root.GetChild(1).Parent, root);

            var anotherRoot = new GeneralTree<int>(2);

            var movedChild = root.GetChild(0);
            anotherRoot.Add(movedChild);

            Assert.AreEqual(movedChild.Parent, anotherRoot);
            Assert.AreEqual(root.Degree, 1);
            Assert.AreEqual(root.GetChild(0).Parent, root);
        }

        [Test]
        public void Interface()
        {
            var root = new GeneralTree<int>(5);

            var child1 = new GeneralTree<int>(2);
            var child2 = new GeneralTree<int>(3);

            ((ITree<int>)root).Add(child1);
            ((ITree<int>)root).Add(child2);

            Assert.AreEqual(root.Count, 2);
            Assert.AreEqual(root.Degree, 2);

            Assert.AreEqual(root.GetChild(0), child1);
            Assert.AreEqual(root.GetChild(0).Data, child1.Data);

            Assert.AreEqual(root.GetChild(1).Data, child2.Data);
            Assert.AreEqual(root.GetChild(1), child2);
        }

    }
}