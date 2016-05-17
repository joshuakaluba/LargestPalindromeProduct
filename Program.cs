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
            //Variables to hold the palindrome and the palindromes factors
            int LargestPalindrome = 0, FirstFactor = 0, SecondFactor = 0;

            for (int i = 100; i < 1000; i++)
            {
                //Loop for the first factor

                for (int z = 100; z < 1000; z++)
                {
                    //Loop for the second factor

                    //Product of the two factors
                    int Product = i * z;

                    //if the product is greater than the last palindromic number that was found
                    if (Product > LargestPalindrome)
                    {
                        //and the product is a palindrome
                        if (IsPalindrome(Product))
                        {
                            //assign the product and its factors to the variables
                            LargestPalindrome = Product;
                            FirstFactor = i;
                            SecondFactor = z;
                        }
                    }

                }
            }

            //output
            Console.WriteLine(FirstFactor.ToString() + " x " + SecondFactor.ToString() + " = " + LargestPalindrome.ToString());            
            Console.Read();


            //Answer = 913 x 993 = 906609
        }

        public static bool IsPalindrome(int Number)
        {
            //Determines if a number passed is a palindromic number

            bool Result = false;

            //convert number to string
            String Num = Number.ToString();

            //convert string to char array
            char[] CharArray = Num.ToCharArray();

            //reverse the char array
            Array.Reverse(CharArray);

            //declare a new string from the reversed char array
            String NumReversed = new string(CharArray);

            //if the original number is equal to the reversed number, it is a palindrome
            if (Num.Equals(NumReversed))
            {
                Result = true;
            }

            return Result;
        }
    }
}
