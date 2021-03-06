/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/



namespace NGenerics.Tests.DataStructures.Mathematical.Vector3DTests
{
    using NGenerics.DataStructures.Mathematical;
    using NUnit.Framework;

    [TestFixture]
    public class ToMatrix
    {

        [Test]
        public void Simple()
        {
            var vector = new Vector3D(8, 3, 7);

            var actual = vector.ToMatrix();

            Assert.AreEqual(3, actual.Rows);
            Assert.AreEqual(1, actual.Columns);

            Assert.AreEqual(8, actual[0, 0]);
            Assert.AreEqual(3, actual[1, 0]);
            Assert.AreEqual(7, actual[2, 0]);
        }

    }
}