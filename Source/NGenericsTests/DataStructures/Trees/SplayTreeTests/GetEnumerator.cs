﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.SplayTreeTests
{
    [TestFixture]
    public class GetEnumerator : SplayTreeTest
    {

        [Test]
        public void Simple()
        {
            var splayTree = GetTestTree();
            var enumerator = splayTree.GetEnumerator();

            var list = new List<KeyValuePair<int, string>>();

            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }

            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(4, "4")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(6, "6")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(2, "2")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(5, "5")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(19, "19")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(1, "1")));

            Assert.AreEqual(list.Count, 6);
        }

        [Test]
        public void Interface()
        {
            var splayTree = GetTestTree();
            var enumerator = ((IEnumerable)splayTree).GetEnumerator();

            var list = new List<KeyValuePair<int, string>>();

            while (enumerator.MoveNext())
            {
                list.Add((KeyValuePair<int, string>)enumerator.Current);
            }

            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(4, "4")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(6, "6")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(2, "2")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(5, "5")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(19, "19")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(1, "1")));

            Assert.AreEqual(list.Count, 6);
        }

        [Test]
        public void KeyValuePairInterface()
        {
            IEnumerable<KeyValuePair<int, string>> splayTree = GetTestTree();
            var enumerator = splayTree.GetEnumerator();

            var list = new List<KeyValuePair<int, string>>();

            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }

            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(4, "4")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(6, "6")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(2, "2")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(5, "5")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(19, "19")));
            Assert.IsTrue(list.Contains(new KeyValuePair<int, string>(1, "1")));

            Assert.AreEqual(list.Count, 6);
        }

    }
}