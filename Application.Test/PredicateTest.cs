using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Test
{
    [TestClass]
    public class PredicateTest
    {
        private Calculator calculator;

        public PredicateTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Unsing_predicate_to_check_if_the_number_is_odd()
        {
            // Assemble - Predicate must to receive a T input
            var number = 3;
            Predicate<int> predicate = (input) => calculator.IsOddNumber(input);

            // Act - Predicate always returns a bool value
            var result = predicate(number);

            // Assert
            Assert.IsTrue(result);
        }
    }
}