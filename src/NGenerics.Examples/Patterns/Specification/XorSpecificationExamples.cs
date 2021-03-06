﻿/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using NGenerics.Patterns.Specification;
using NUnit.Framework;

namespace NGenerics.Examples.Patterns.Specification
{
    [TestFixture]
    public class XorSpecificationExamples
    {
        #region IsSatisfiedBy
        
        [Test]
        public void IsSatisfiedByExample()
        {
            var divisibleByTwoSpecification = new PredicateSpecification<int>(x => x % 2 == 0);
            var divisibleByThreeSpecification = new PredicateSpecification<int>(x => x % 3 == 0);

            var xorSpecifciation = new XorSpecification<int>(divisibleByTwoSpecification, divisibleByThreeSpecification);

            // Not divisible by either two or three
            Assert.IsFalse(xorSpecifciation.IsSatisfiedBy(1));
            
            // Divisible by two only
            Assert.IsTrue(xorSpecifciation.IsSatisfiedBy(2));

            // Divisible by thee only
            Assert.IsTrue(xorSpecifciation.IsSatisfiedBy(3));
            
            // Divisible by two and three
            Assert.IsFalse(xorSpecifciation.IsSatisfiedBy(6));
        }

        #endregion
    }
}