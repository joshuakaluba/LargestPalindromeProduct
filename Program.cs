using System;

/// <summary>
/// Joshua Kaluba 
/// 2016-05-16
/// My take on the problem presented at --> https://projecteuler.net/problem=4
/// 
/// Problem states :  
/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
/// Find the largest palindrome made from the product of two 3-digit numbers.
/// </summary>

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int LargestPalindrome = 0, FirstFactor = 0, SecondFactor = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int z = 100; z < 1000; z++)
                {
                    int Product = i * z;

                    if (Product > LargestPalindrome)
                    {
                        if (IsPalindrome(Product))
                        {
                            LargestPalindrome = Product;
                            FirstFactor = i;
                            SecondFactor = z;
                        }
                    }

                }
            }

            Console.WriteLine(FirstFactor.ToString() + " x " + SecondFactor.ToString() + " = " + LargestPalindrome.ToString());
            Console.Read();
        }

        public static bool IsPalindrome(int Number)
        {
            bool Result = false;

            String Num = Number.ToString();

            char[] CharArray = Num.ToCharArray();
            Array.Reverse(CharArray);
            String NumReversed = new string(CharArray);

            if (Num.Equals(NumReversed))
            {
                Result = true;
            }

            return Result;
        }
    }
}
