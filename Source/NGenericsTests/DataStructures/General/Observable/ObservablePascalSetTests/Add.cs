﻿using System;
using NGenerics.DataStructures.General.Observable;
using NGenerics.Tests.TestObjects;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.Observable.ObservablePascalSetTests
{
    [TestFixture]
    public class Add
    {
        [Test]
        public void Simple()
        {
            var pascalSet = new ObservablePascalSet(10);
            ObservableCollectionTester.ExpectEvents(pascalSet, obj => obj.Add(4), "Count", "LowerBound", "UpperBound", "Capacity", "IsFull", "Item[]");
                
        }


        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptionReentrancy()
        {
            var pascalSet = new ObservablePascalSet(10);
            new ReentracyTester<ObservablePascalSet>(pascalSet, obj => obj.Add(4), obj => obj.Add(5));
        }
    }
}