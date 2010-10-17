﻿using System.Collections.Generic;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.SplayTreeTests
{
    [TestFixture]
    public class GetSortedEnumerator : SplayTreeTest
    {

        [Test]
        public void Simple()
        {
            var splayTree = GetTestTree();
            var enumerator = splayTree.GetOrderedEnumerator();

            var list = new List<KeyValuePair<int, string>>();

            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }

            Assert.AreEqual(list.Count, 6);

            Assert.AreEqual(list[0], new KeyValuePair<int, string>(1, "1"));
            Assert.AreEqual(list[1], new KeyValuePair<int, string>(2, "2"));
            Assert.AreEqual(list[2], new KeyValuePair<int, string>(4, "4"));
            Assert.AreEqual(list[3], new KeyValuePair<int, string>(5, "5"));
            Assert.AreEqual(list[4], new KeyValuePair<int, string>(6, "6"));
            Assert.AreEqual(list[5], new KeyValuePair<int, string>(19, "19"));
        }

    }
}