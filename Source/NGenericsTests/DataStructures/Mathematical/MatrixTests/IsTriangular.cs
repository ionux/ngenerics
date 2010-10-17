﻿using System;
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class IsTriangular
    {

        [Test]
        public void Simple()
        {
            var matrix = new Matrix(3, 3);

            // [ 1,  4,  7 ]
            // [ 2,  5,  8 ]
            // [ 3,  6,  9 ]


            matrix[0, 0] = 1;
            matrix[0, 1] = 4;
            matrix[0, 2] = 7;

            matrix[1, 0] = 0;
            matrix[1, 1] = 5;
            matrix[1, 2] = 8;

            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 0;


            Console.WriteLine(matrix);
            Assert.AreEqual(matrix.IsTriangular, TriangularMatrixType.Upper);
            matrix = matrix.Transpose();
            Console.WriteLine(matrix);
            Assert.AreEqual(matrix.IsTriangular, TriangularMatrixType.Lower);
        }

        [Test]
        public void DifferingNumberOfColumnsAndRows()
        {
            var matrix = new Matrix(3, 4);
            Assert.AreEqual(TriangularMatrixType.None, matrix.IsTriangular);
        }

    }
}