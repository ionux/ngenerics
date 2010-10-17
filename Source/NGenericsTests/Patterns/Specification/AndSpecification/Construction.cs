﻿using System;
using NGenerics.Patterns.Specification;
using NUnit.Framework;

namespace NGenerics.Tests.Patterns.Specification.AndSpecification
{
    [TestFixture]
    public class Construction
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_Throw_If_Left_Specification_Is_Null()
        {
            new AndSpecification<int>(null, new PredicateSpecification<int>(x => x == 5));
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_Throw_If_Right_Specification_Is_Null()
        {
            new AndSpecification<int>(new PredicateSpecification<int>(x => x == 5), null);
        }

        [Test]
        public void Should_Be_Fine_If_None_Are_Null()
        {
            var p1 = new PredicateSpecification<int>(x => x == 5);
            var p2 = new PredicateSpecification<int>(x => x >= 5);

            var spec = new AndSpecification<int>(p1, p2);

            Assert.AreEqual(spec.Left, p1);
            Assert.AreEqual(spec.Right, p2);
        }
    }
}