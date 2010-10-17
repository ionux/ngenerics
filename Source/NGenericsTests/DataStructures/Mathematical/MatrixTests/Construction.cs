﻿using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class Construction
    {
        [Test]
        public void Should_Copy_Multi_Dimensional_Array_For_Data()
        {
            var values = new double[4,3];
                
            for (var i = 0; i< 4; i++)
            {
                for (var j = 2; j>= 0; j--)
                {
                    values[i, j] = i + j;
                }
            }
                
            var m = new Matrix(4, 3, values);

            for (var i = 0; i < 4; i++)
            {
                for (var j = 2; j >= 0; j--)
                {
                    Assert.AreEqual(m[i, j], i + j);
                }
            }
                
        }
    }
}