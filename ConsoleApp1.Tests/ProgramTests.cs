using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void IsResultTheSame_TwoEqualNumbersAreGiven_ReturnsTrue()
        {
            //arrange
            double a = 2 + 2;
            double b = 2 * 2;

            //act
            bool result = Program.IsResultTheSame(a, b);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsResultTheSame_TwoNotEqualNumbersAreGiven_ReturnsFalse()
        {
            //arrange
            double a = 2 + 2;
            double b = 2 * 3;

            //act
            bool result = Program.IsResultTheSame(a, b);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AbsoluteValue_PositiveNumberIsGiven_ReturnsTheSameNumber()
        {
            //arrange
            int a = 6832;

            //act
            int result = Program.AbsoluteValue(a);

            //assert
            Assert.AreEqual(a,result);
        }

        [TestMethod]
        public void AbsoluteValue_NegativeNumberIsGiven_ReturnsOppositeNumber()
        {
            //arrange
            int a = -392;
            int expected = 392;

            //act
            int result = Program.AbsoluteValue(a);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivisibleBy2Or3_TwoNumbersDivisibleBy3AreGiven_ReturnsResultOfMultiplication()
        {
            //arrange
            int a = 15;
            int b = 30;
            

            //act
            int result = Program.DivisibleBy2Or3(a, b);

            //assert
            Assert.AreEqual(a*b, result);
        }

        [TestMethod]
        public void DivisibleBy2Or3_TwoNumbersDivisibleBy2AreGiven_ReturnsResultOfMultiplication()
        {
            //arrange
            int a = 2;
            int b = 90;


            //act
            int result = Program.DivisibleBy2Or3(a, b);

            //assert
            Assert.AreEqual(a * b, result);
        }

        [TestMethod]
        public void DivisibleBy2Or3_TwoNumbersNotDivisibleBy2Or3AreGiven_ReturnsResultOfAddition()
        {
            //arrange
            int a = 7;
            int b = 12;


            //act
            int result = Program.DivisibleBy2Or3(a, b);

            //assert
            Assert.AreEqual(a + b, result);
        }

        [DataTestMethod]
        [DataRow("xyz",false)]
        [DataRow("DOG",true)]
        [DataRow("8PL",false)]
        public void IfConsistsOfUppercaseLetters_3CharsStringIsGiven_ReturnsTrueIfConditionIsMet(string input, bool expected)
        {
            //arrange

            //act
            bool result = Program.IfConsistsOfUppercaseLetters(input);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-5, -8, 50, false)]
        [DataRow(2, 7, 12, true)]
        public void IfGreaterThanThirdOne_ArrayOf3IntsIsGiven_ReturnsTrueIfConditionIsMet(int a, int b, int c, bool expected)
        {
            //arrange
            int[] numbers = { a, b, c };

            //act
            bool result = Program.IfGreaterThanThirdOne(numbers);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(721, false)]
        [DataRow(1248, true)]
        public void IfNumberIsEven_IntIsGiven_ReturnsTrueIfConditionIsMet(int a, bool expected)
        {
            //arrange

            //act
            bool result = Program.IfNumberInEven(a);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(74, 62, 99, false)]
        [DataRow(3, 7, 10, true)]
        public void IfSortedAscending_ArrayOf3IntsIsGiven_ReturnsTrueIfConditionIsMet(int a, int b, int c, bool expected)
        {
            //arrange
            int[] numbers = { a, b, c };

            //act
            bool result = Program.IfSortedAscending(numbers);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PositiveNegativeOrZero_PositiveNumberIsGiven_ReturnStringPositive()
        {
            //arrange
            double a = 5.24;
            string expected = "positive";

            //act
            string result = Program.PositiveNegativeOrZero(a);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PositiveNegativeOrZero_NegativeNumberIsGiven_ReturnStringNegative()
        {
            //arrange
            double a = -994.53;
            string expected = "negative";

            //act
            string result = Program.PositiveNegativeOrZero(a);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PositiveNegativeOrZero_ZeroIsGiven_ReturnStringZero()
        {
            //arrange
            double a = 0.0;
            string expected = "zero";

            //act
            string result = Program.PositiveNegativeOrZero(a);

            //assert
            Assert.AreEqual(expected, result);
        }


        [DataTestMethod]
        [DataRow(2018, false)]
        [DataRow(2016, true)]
        public void IfYearIsLeap_YearIsGiven_ReturnsTrueIfConditionIsMet(int year, bool expected)
        {
            //arrange

            //act
            bool result = Program.IfYearIsLeap(year);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(87501, false)]
        [DataRow(7201432, true)]
        public void IfNumberContains3_NumberIsGiven_ReturnsTrueIfConditionIsMet(int number, bool expected)
        {
            //arrange

            //act
            bool result = Program.IfYearIsLeap(number);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(3, 1.36111111111111)]
        [DataRow(5, 1.46361111111111)]
        public void FractionsSum_IntIsGiven_ReturnsFractionsSum(int n, double expected)
        {
            //arrange

            //act
            double result = Program.FractionsSum(n);

            //assert
            Assert.AreEqual(Math.Round(expected,5), Math.Round(result,5));
        }

        [TestMethod]
        public void SortArrayAscending_ArrayOfIntegersInRandomOrderIsGiven_ReturnsSortedArray()
        {
            //arrange
            int[] numbers = { 9, 5, 7, 2, 1, 8 };
            int[] expected = { 1, 2, 5, 7, 8, 9 };

            //act
            int[] result = Program.SortArrayAscending(numbers);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
