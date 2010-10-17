﻿using System;
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.LUDecompositionTests
{
    [TestFixture]
    public class Solve
    {
        [Test]
        public void Simple()
        {
            var matrixA = new Matrix(2, 2);

            matrixA[0, 0] = 0;
            matrixA[0, 1] = 1;

            matrixA[1, 0] = 2;
            matrixA[1, 1] = 0;

            var matrixB = new Matrix(2, 2);

            matrixB[0, 0] = 1;
            matrixB[0, 1] = 0;

            matrixB[1, 0] = 0;
            matrixB[1, 1] = -1;

            var decomposition = new LUDecomposition(matrixA);
            var solveMatrix = decomposition.Solve(matrixB);

            Assert.AreEqual(solveMatrix.Rows, 2);
            Assert.AreEqual(solveMatrix.Columns, 2);

            Assert.AreEqual(solveMatrix[0, 0], 0);
            Assert.AreEqual(solveMatrix[0, 1], -0.5);

            Assert.AreEqual(solveMatrix[1, 0], 1);
            Assert.AreEqual(solveMatrix[1, 1], 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionDifferentRowCounts()
        {
            var matrixA = new Matrix(2, 2);

            matrixA[0, 0] = 0;
            matrixA[0, 1] = 1;

            matrixA[1, 0] = 2;
            matrixA[1, 1] = 0;

            var matrixB = new Matrix(3, 2);

            matrixB[0, 0] = 1;
            matrixB[0, 1] = 0;

            matrixB[1, 0] = 0;
            matrixB[1, 1] = -1;

            matrixB[2, 0] = 1;
            matrixB[2, 1] = 3;

            var decomposition = new LUDecomposition(matrixA);
            var solveMatrix = decomposition.Solve(matrixB);
        }

    }
}