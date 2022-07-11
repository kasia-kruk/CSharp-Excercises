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

        [DataTestMethod]
        [DataRow(190, 291, 145, 209, 280, 291)]
        [DataRow(-9, -2, -7, -8, -4, -2)]
        public void TheBiggestNumber_ArrayOfIntsIsGiven_ReturnsTheHighestValue(int a, int b, int c, int d, int e, int expected)
        {
            //arrange
            int[] numbers = { a, b, c, d, e };

            //act
            int result = Program.TheBiggestNumber(numbers);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(190, 291, 7, 7, 280, 1)]
        [DataRow(3, 7, 7, 7, 7, 3)]
        public void Two7sNextToEachOther_ArrayOfIntsIsGiven_ReturnsNumberOf7sNextToEachOther(int a, int b, int c, int d, int e, int expected)
        {
            //arrange
            int[] numbers = { a, b, c, d, e };

            //act
            int result = Program.Two7sNextToEachOther(numbers);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(83, 2)]
        [DataRow(40002938, 8)]
        public void DigitalRoot_PositiveIntigerIsGiven_ReturnsItsDigitalRoot(int number, int expected)
        {
            //arrange

            //act
            int result = Program.DigitalRoot(number);

            //assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 4, 5, true)]
        [DataRow(4, 9, 6, 3, 7, false)]
        public void ThreeIncreasingAdjacent_ArrayOfIntigerIsGiven_ReturnsTrueIfThereAreThreeAdjacent(int a, int b, int c, int d, int e, bool expected)
        {
            //arrange
            int[] numbers = { a, b, c, d, e };

            //act
            bool result = Program.ThreeIncreasingAdjacent(numbers);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnEvenNumbers_ReturnsStringWithEvenNumbers()
        {
            //arrange
            string expected = "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98";

            //act
            string result = Program.ReturnEvenNumbers();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SieveOfEratosthenes_IntegerIsGiven_ReturnsArrayOfPrimeNumbers()
        {
            //arrange
            int[] expected = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int input = 30;
            int expectedCount = 10;

            //act
            int[] result = Program.SieveOfEratosthenes(input);

            //assert
            Assert.AreEqual(expectedCount, result.Length);
            Assert.AreEqual(expected[2], result[2]);
            Assert.AreEqual(expected[5], result[5]);
            Assert.AreEqual(expected[9], result[9]);
        }

        [DataTestMethod]
        [DataRow("##abc##def", "abc")]
        [DataRow("12####78", "")]
        [DataRow("gar##d#en", "")]
        [DataRow("++##--##++", "--")]
        public void ExtractString_StringIsGiven_ReturnsContentBetweenDoubleHashtags(string input, string expected)
        {
            //arrange

            //act
            string result = Program.ExtractString(input);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}