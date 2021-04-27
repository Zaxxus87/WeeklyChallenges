using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int ans = startNumber+1;
            
            while(ans > 0)
            {
                if (ans % n == 0)
                    return ans;
                else
                    ans++;
            }
            return ans;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business item in businesses)
            {
                if (item.TotalRevenue == 0)
                    item.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            for (int i = 0; i < numbers.Length - 1; i++)
                if (numbers[i] > numbers[i + 1])
                    return false;
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var total = 0;
            if (numbers == null || numbers.Length == 0)
                return 0;
            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i - 1] % 2 == 0)
                    total += numbers[i];
            return total;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";
            string ans = "";
            foreach(string word in words)
                if(string.IsNullOrWhiteSpace(word) == false)
                   ans += word.Trim(' ') + " ";
            if (ans.Length == 0)
                return "";
            return ans.TrimEnd(' ') + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
