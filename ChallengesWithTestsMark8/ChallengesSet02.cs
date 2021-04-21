using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return Math.Abs(num) % 2 == 1;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            if (numbers.Count() == 0)
                return 0;
            double smallest = numbers.Min();
            double largest = numbers.Max();
            return smallest + largest;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
                return str1.Length;
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            foreach (int num in numbers)
                if (Math.Abs(num) % 2 == 0)
                    sum += num;
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            var sum = numbers.Sum();
            return (Math.Abs(sum) % 2 == 1);
               
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int i = 1; i < number; i++)
                if (i % 2 == 1)
                    count++;
            return count;
        }
    }
}
