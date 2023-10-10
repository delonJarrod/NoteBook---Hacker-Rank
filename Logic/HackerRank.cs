using NoteBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Logic
{
    public class HackerRank : IHackerRank
    {
        // -------------------------------------------------------------------------------------------------------------
        // challange 1 Start
        public void TextToMaths()
        {
            Console.WriteLine("Enter Expression here >> eg. one plus one");
            string expression = Console.ReadLine();
            string[] brokenExpression = expression.Split(' ');
            int firstValue = TextMathsParesNumber(brokenExpression[0]);
            int secondValue = TextMathsParesNumber(brokenExpression[2]);
            string operatorSign = TextMathsParesOperator(brokenExpression[1]);

            if (brokenExpression.Length != 3)
            {
                Console.WriteLine("Invalid expression");
                return;
            }
            int result = PerformCalc(firstValue, secondValue, operatorSign);
            Console.WriteLine($"Expression: {firstValue} {brokenExpression[1]} {secondValue}");
            Console.WriteLine($"Result: {result}");

            Console.Read();
        }
        private int TextMathsParesNumber(string input)
        {

            Dictionary<string, int> WordToNumberMap = new Dictionary<string, int>{
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
            { "ten", 10 }
            };

            if (WordToNumberMap.TryGetValue(input.ToLower(), out int number))
            {
                return number;
            }
            else
            {
                throw new ArgumentException("Invalid input number");
            }
        }
        private string TextMathsParesOperator(string op)
        {

            Dictionary<string, string> OperatorToSign = new Dictionary<string, string>
            {
                {"plus", "+" },
                {"add", "+" },
                {"more", "+" },
                {"less", "-" },
                {"subtract", "-" },
                {"minus", "-" },
                {"divide", "/" },
                {"multiply", "*" },
            };

            if (OperatorToSign.TryGetValue(op, out string value))
            {
                return value;
            }
            else
            {
                throw new ArgumentException("Invalid operator");
            }

        }
        private int PerformCalc(int first, int second, string op)
        {
            switch (op)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "/":
                    return first / second;
                case "*":
                    return first * second;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
        // challange 1 End
        // -------------------------------------------------------------------------------------------------------------



        // -------------------------------------------------------------------------------------------------------------
        // Challange 2 Start
        public void AgeClassified()
        {
            Console.WriteLine("Enter your age below >> eg. 21");
            string Age = Console.ReadLine();
            string result = AgeClassifiedChecker(int.Parse(Age));
            if(result == null)
            {
                throw new ArgumentException("Internal error");
            }
            else
            {
                Console.WriteLine($"Result: {result}");
            }
            Console.Read();

           
        }
        private string AgeClassifiedChecker(int Age)
        {
           if(Age <= 15)
            {
                return "Teenager";
            }else if(Age > 15 && Age <= 21)
            {
                return "Young adult";
            }
            else if (Age >= 40 && Age <= 55)
            {
                return "Middle Aged";
            }
            else if (Age >= 56 && Age <= 80)
            {
                return "Old Aged";
            }
            else if (Age >= 200)
            {
                return "Should be dead";
            }
            else
            {
                throw new ArgumentException("Invalid Age range");
            }
        }
        // challange 2 End
        // -------------------------------------------------------------------------------------------------------------



        // -------------------------------------------------------------------------------------------------------------
        // Challange 3 Start
        public void FuzzBuzz()
        {
            Console.WriteLine("Enter a numeric value below >> eg. 150");
            string input = Console.ReadLine();
            if(input == null)
            {
                throw new ArgumentException("Invailed Input");
            }
            else
            {
                FuzzBuzzChecker(int.Parse(input));
            }
            
            Console.Read();
        }
        private void FuzzBuzzChecker(int input)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Start");
            Console.WriteLine("-------------------");
            for (int i = 1; i < input; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FuzzBuzz");
                }else if (i % 3 == 0 && i % 5 != 0)
                {
                   Console.WriteLine("Fuzz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                   Console.WriteLine("Buzz");
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine("-------------------");
        }
        // challange 3 End



        // -------------------------------------------------------------------------------------------------------------
        // Challange 4 Start
        public void plusMinus()
        {
            int[] arr = { 1, -2, 0, 3, -4, 5, 0 };
            int total = arr.Length;
            int positive = 0, negative = 0, zero = 0;

            foreach (var item in arr)
            {
                if (item > 0) positive++;
                else if (item < 0) negative++;
                else zero++;
            }

            double positiveRatio = (double)positive / total;
            double negativeRatio = (double)negative / total;
            double zeroRatio = (double)zero / total;

            Console.WriteLine($"{positiveRatio:F6}");
            Console.WriteLine($"{negativeRatio:F6}");
            Console.WriteLine($"{zeroRatio:F6}");

            Console.Read();

        }
        // -------------------------------------------------------------------------------------------------------------
        // Challange 4 End



        // -------------------------------------------------------------------------------------------------------------
        // Challange 5 Start
        public void miniMaxSum()
        {
            int[] arr = { 1, 2 ,3, 4, 5 };

            long totalSum = 0;
            long maxNumber = Int64.MinValue;
            long minNumber = Int64.MaxValue;

            foreach (int num in arr)
            {
                totalSum += num;
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }

            long maxSum = totalSum - minNumber;
            long minSum = totalSum - maxNumber;

            Console.WriteLine($"{minSum} {maxSum}");
            Console.Read();
        }
        // -------------------------------------------------------------------------------------------------------------
        // Challange 5 End




        // -------------------------------------------------------------------------------------------------------------
        // Challange 6 Start
        public void timeConversion()
        {
            string s = "07:05:45PM";
            DateTime time = DateTime.ParseExact(s, "hh:mm:sstt", null);
            string militaryTime = time.ToString("HH:mm:ss");
            Console.WriteLine($"{militaryTime}");
            Console.Read();
        }
        // -------------------------------------------------------------------------------------------------------------
        // Challange 6 End
    }


}
