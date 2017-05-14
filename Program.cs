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
	internal class Program
	{
		private static void Main ( string[] args )
		{
			//Variables to hold the palindrome and the palindromes factors
			int largestPalindrome = 0, firstFactor = 0, secondFactor = 0;

			for ( int i = 100 ; i < 1000 ; i++ )
			{
				//Loop for the first factor

				for ( int z = 100 ; z < 1000 ; z++ )
				{
					//Loop for the second factor

					//Product of the two factors
					int product = i * z;

					//if the product is greater than the last palindromic number that was found
					if ( product > largestPalindrome )
					{
						//and the product is a palindrome
						if ( IsPalindrome( product.ToString() ))
						{
							//assign the product and its factors to the variables
							largestPalindrome = product;
							firstFactor = i;
							secondFactor = z;
						}
					}
				}
			}

			//output
			Console.WriteLine( String.Format("{0} * {1} = {2}", 
									firstFactor.ToString(), 
										secondFactor.ToString(), 
											largestPalindrome.ToString() ) );

			Console.Read();

			//Answer = 913 x 993 = 906609
		}

		public static bool IsPalindrome ( string number )
		{
			//Determines if a number passed is a palindromic number

			bool result = false;

			//convert string to char array
			char[ ] charArray = number.ToCharArray();

			//reverse the char array
			Array.Reverse( charArray );

			//declare a new string from the reversed char array
			String numberReversed = new string( charArray );

			//if the original number is equal to the reversed number, it is a palindrome
			if ( number.Equals( numberReversed ) )
			{
				result = true;
			}

			return result;
		}
	}
}