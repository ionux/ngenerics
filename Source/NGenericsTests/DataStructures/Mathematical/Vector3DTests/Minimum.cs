﻿using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.Vector3DTests
{
    [TestFixture]
    public class Minimum
    {

        [Test]
        public void Simple()
        {
            var vector = new Vector3D(1, -4, 3);

            Assert.AreEqual(-4, vector.Minimum());
            Assert.AreEqual(1, vector.X);
            Assert.AreEqual(-4, vector.Y);
            Assert.AreEqual(3, vector.Z);
        }

    }
}