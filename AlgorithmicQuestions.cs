using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
   public static  class AlgorithmicQuestions
    {
       public static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            int left = 0, right = chars.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }

            return new string(chars);
        }
       public static bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

    }
}
