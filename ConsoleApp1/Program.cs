using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int result = AddAndMultiply(2, 4, 5);
            //string result = CtoF(100);
            //string result = ElementaryOperations(3, 8);
            //bool result = IsResultTheSame(2 + 2, 2 * 2);
            //int result = ModuloOperations(8, 5, 2);
            //double result = TheCubeOf(-5.5);
            //Console.WriteLine(result);

            PrintMultiplicationTable();

            Console.ReadLine();
        }

        public static string ExtractString(string input)
        {
            var splittedInput = input.Split("##");
            if (splittedInput.Length != 3)
            {
                return string.Empty;
            }
            return splittedInput[1];
        }

        public static int[] SieveOfEratosthenes(int n)
        {
            if (n<2)
            {
                return null;
            }

            List<int> primeNumbers = new List<int>() { 2 };

            for (int i = 3; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i ; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers.ToArray();
        }

        public static string ReturnEvenNumbers()
        {
            string output = "";
            for (int i = 1; i < 100; i++)
            {
                if (i%2==0)
                {
                    output = output + i + " ";
                }
            }
            return output.Trim();
        }

        public static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            for (int i = 1; i < numbers.Length-1; i++)
            {
                if (numbers[i] - numbers[i-1] == 1 && numbers[i + 1] - numbers[i] == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public static int DigitalRoot(int number)
        {
            string numberAsString = number.ToString();
            char[] stringAsCharsArray = numberAsString.ToCharArray();

            int digitalRoot = 0;

            while (stringAsCharsArray.Length > 1)
            {
                digitalRoot = 0;
                foreach (var c in stringAsCharsArray)
                {
                    digitalRoot += Convert.ToInt32(c.ToString());
                }

                numberAsString = digitalRoot.ToString();
                stringAsCharsArray = numberAsString.ToCharArray();
                
            }

            return digitalRoot;
        }

        public static int Two7sNextToEachOther(int[] numbers)
        {
            int counter = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 7 && numbers[i-1] == 7)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int TheBiggestNumber(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]>result)
                {
                    result = numbers[i];
                }
            }
            return result;
        }

        public static int[] SortArrayAscending(int[] numbers)
        {
            bool isChanged;

            do
            {
                isChanged = false;
                
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    if (numbers[i] > numbers[i+1])
                    {
                        int temp = numbers[i+1];
                        numbers[i+1] = numbers[i];
                        numbers[i] = temp;
                        isChanged = true;
                    }
                }
            } 
            while (isChanged);

            return numbers;
        }

        public static double FractionsSum(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += (1.0 /(double) i)*(1.0/(double)i);
            }

            return sum;
        }

        public static void PrintMultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                string line = "";
                for (int j = 1; j <=10; j++)
                {
                    if (line == "")
                    {
                        line = line + j * i;
                    }
                    else
                    {
                        line = line + "\t" + j * i;
                    }
                }

                Console.WriteLine(line);
            }
        }

        public static bool IfNumberContains3(int number)
        {
            foreach (char c in number.ToString())
            {
                if (c == '3')
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IfYearIsLeap(int year)
        {
            if ((year-2016)%4==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string PositiveNegativeOrZero(double a)
        {
            if (a > 0)
            {
                return "positive";
            }
            else if (a < 0)
            {
                return "negative";
            }
            else 
            {
                return "zero";
            }
         
        }

        public static bool IfSortedAscending(int[] numbers)
        {
            if (numbers[0] <= numbers[1] && numbers[1] <= numbers[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IfNumberInEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IfGreaterThanThirdOne(int[] numbers)
        {
            if (numbers[0] * numbers[1] > numbers[2] || numbers[0] + numbers[1] > numbers[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IfConsistsOfUppercaseLetters(string input)       //"xyz","DOG","8PL"
        {
            foreach (char c in input)
            {
                if (Int32.TryParse(c.ToString(),out int result))
                {
                    return false;
                }
            }

            if (input == input.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int DivisibleBy2Or3(int a, int b)
        {
            int result = 0;

            if ((a%2==0 && b%2==0) || (a % 3 == 0 && b % 3 == 0))
            {
                result = a * b;
            }
            else
            {
                result = a + b;
            }

            return result;
        }

        public static int AbsoluteValue(int a)
        {
            return Math.Abs(a);
        }

        public static double TheCubeOf(double a)
        {
            //return a * a * a;
            return Math.Pow(a, 3);
        }

        public static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }

        public static bool IsResultTheSame(double a, double b)
        {
            return a == b; 
        }

        public static string ElementaryOperations(int x, int y)
        {
            if (y == 0)
            {
                return "You can't divide any number by 0!";
            }
            return $"{x + y}, {x - y}, {x * y}, {(double)x / (double)y}";
        }

        public static string CtoF(double c)
        {
            double f;
            if (c < -271.15)
            {
                return "Temperture below absolute zero!";
            }
            f = c * 9 / 5 + 32;
            return $"T = {f}F";
        }

        public static int AddAndMultiply(int a, int b, int c)
        {
            return (a + b) * c;
        }
    }
}
