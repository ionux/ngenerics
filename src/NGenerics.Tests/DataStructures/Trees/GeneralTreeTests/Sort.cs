/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using System.Collections.Generic;
using NGenerics.DataStructures.Trees;
using NGenerics.Sorting;
using NGenerics.Tests.Util;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.GeneralTreeTests
{
    [TestFixture]
    public class Sort : GeneralTreeTest
    {

        [Test]
        public void ExceptionInterface()
        {
            ISortable<GeneralTree<int>> tree = GetTestTree();
            Assert.Throws<NotSupportedException>(() => tree.Sort(null));
        }

        [Test]
        public void Comparison()
        {
            var tree = GetTestTree();

            tree.Sort(new InsertionSorter<GeneralTree<int>>(), (x, y) => x.Data.CompareTo(y.Data));

            Assert.AreEqual(tree.ChildNodes[0].Data, 1);
            Assert.AreEqual(tree.ChildNodes[1].Data, 2);
            Assert.AreEqual(tree.ChildNodes[2].Data, 3);
        }

        [Test]
        public void Comparer()
        {
            var tree = GetTestTree();

            tree.Sort(new InsertionSorter<GeneralTree<int>>(),
                      new GeneralTreeComparer<int>());

            Assert.AreEqual(tree.ChildNodes[0].Data, 1);
            Assert.AreEqual(tree.ChildNodes[1].Data, 2);
            Assert.AreEqual(tree.ChildNodes[2].Data, 3);
        }

        [Test]
        public void ExceptionNullComparisonSorter1()
        {
            var tree = GetTestTree();

            Assert.Throws<ArgumentNullException>(() => tree.Sort(null, (x, y) => x.Data.CompareTo(y.Data)));
        }

        [Test]
        public void ExceptionNullComparisonSorter2()
        {
            var tree = GetTestTree();

            Assert.Throws<ArgumentNullException>(() => tree.Sort(null, new GeneralTreeComparer<int>()));
        }

        [Test]
        public void ExceptionNullComparison1()
        {
            var tree = GetTestTree();
            Assert.Throws<ArgumentNullException>(
                () => tree.Sort(new InsertionSorter<GeneralTree<int>>(), (Comparison<GeneralTree<int>>)null));
        }

        [Test]
        public void ExceptionNullSorter()
        {
            var tree = GetTestTree();
            Assert.Throws<ArgumentNullException>(() => tree.Sort(null, SortOrder.Descending));
        }

        [Test]
        public void ExceptionNullComparer1()
        {
            var tree = GetTestTree();

            Assert.Throws<ArgumentNullException>(
                () => tree.Sort(new InsertionSorter<GeneralTree<int>>(), (IComparer<GeneralTree<int>>)null));
        }

    }
}