using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool isPalindrome(int Number)
        {
            bool result = false;

            String res = Number.ToString();

            char[] charArray = res.ToCharArray();
            Array.Reverse(charArray);
            String resReversed = new string(charArray);

            if (res.Equals(resReversed))
            {
                result = true;
            }

            return result;
        }
    }
}
