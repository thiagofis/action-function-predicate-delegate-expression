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
            // Assemble - Predicate must to receive a T input, it is only one input per Predicate
            var number = 3;
            Predicate<int> predicate = (input) => calculator.IsOddNumber(input);

            // Act - Predicate always returns a bool value
            var result = predicate(number);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Unsing_predicate_to_check_if_the_sum_of_two_numbers_is_odd()
        {
            // Assemble - pass a arry or object if you need more than one input 
            int[] numbers = { 3, 4 };

            Predicate<int[]> predicate = (input) => 
            {
                var sum = calculator.Sum(input[0], input[1]);
                return calculator.IsOddNumber(sum);
            };

            // Act - Predicate always returns a bool value
            var result = predicate(numbers);

            // Assert
            Assert.IsTrue(result);
        }
    }
}