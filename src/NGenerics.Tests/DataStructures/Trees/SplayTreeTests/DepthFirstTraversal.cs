/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System.Collections.Generic;
using NGenerics.DataStructures.Trees;
using NGenerics.Patterns.Visitor;
using NGenerics.Tests.TestObjects;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Trees.SplayTreeTests
{
    [TestFixture]
    public class DepthFirstTraversal : SplayTreeTest
    {
        [Test]
        public void Simple()
        {
            var splayTree = new SplayTree<string, int>
                                {
                                    new KeyValuePair<string, int>("horse", 4),
                                    new KeyValuePair<string, int>("cat", 1),
                                    new KeyValuePair<string, int>("dog", 2),
                                    new KeyValuePair<string, int>("canary", 3)
                                };

            var visitor = new AssertionVisitor<KeyValuePair<string, int>>();

            var inOrderVisitor = new InOrderVisitor<KeyValuePair<string, int>>(visitor);

            splayTree.DepthFirstTraversal(inOrderVisitor);

            visitor.AssertTracked(x => x.Key, "canary", "cat", "dog", "horse");
        }
    }
}