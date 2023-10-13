using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_nmbers_are_polindrom
{
    internal class Program
    {
        static bool IsPalindrome(int number)
        {
            if (number < 0)
            {
                return false;
            }
            int reversedNumber = 0;
            int originalNumber = number;
            while (originalNumber > 0)
            {
                int lastDigit = originalNumber % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                originalNumber /= 10;
            }
            return number == reversedNumber;


        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a palindrome:");
            int number = int.Parse(Console.ReadLine());
            bool isPalindrome = IsPalindrome(number);
            if (isPalindrome == true)
            {
                Console.WriteLine("The number {0} is a palindrome.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not a palindrome.", number);
            }
        }   
    }
}
