using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int ans = 0;
            foreach (int num in numbers)
                if (num % 2 == 0)
                    ans += num;
                else
                    ans -= num;
            return ans;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> ans = new List<int>() { str1.Length, 
                                              str2.Length, 
                                              str3.Length, 
                                              str4.Length };
            return ans.Min();
        }   

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> ans = new List<int>() { number1,
                                              number2,
                                              number3,
                                              number4 };
            return ans.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            List<int> sides = new List<int>(){sideLength1,
                                              sideLength2,
                                              sideLength3,};
            if (sides.Min() <= 0)
                return false;
            return sides.Sum() - sides.Max() > sides.Max(); 

        }

        public bool IsStringANumber(string input)
        {
            int i =  0;
            double d = 0.0;
            if (input == "" || input == null)
                return false;
            if (int.TryParse(input, out i) || 
                double.TryParse(input, out d))
                return true;
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nulls = 0;
            foreach (object item in objs)
            {
                if (item == null)
                    nulls++;
            }
            int nonNulls = objs.Length - nulls;
            return nulls > nonNulls;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
                return 0;
            var evens = numbers.Where(x => Math.Abs(x) % 2 == 0);
            if (evens.Count() == 0)
                return 0;
            return (double)evens.Sum() / evens.Count();
        }

        public int Factorial(int number)
        {
            int ans = 1;
            for (int i = 2; i <= number; i++)
                ans *= 2;
            return ans;

        }
    }
}
