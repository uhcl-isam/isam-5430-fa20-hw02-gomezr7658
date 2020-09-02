// University of Houston Clear Lake
// ISAM 5430   Roberto Gomez

using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // Declare variables
            int number = 0;
            int num1, num2, num3, num4, num5, num6, num7, num8, num9;

            // Enter the number
            Console.Write("Enter a number (9 digits only) :  ");
            number = Convert.ToInt32(Console.ReadLine());

            // Separate all the digits
            num1 = number / 100000000;
            num2 = (number % 100000000) / 10000000;
            num3 = (number % 10000000) / 1000000;
            num4 = (number % 1000000) / 100000;
            num5 = (number % 100000) / 10000;          
            num6 = (number % 10000) / 1000;
            num7 = (number % 1000) / 100;
            num8 = (number % 100) / 10;
            num9 = number % 10;
            
            // Check if the number is palindrome
            if (num1 == num9)
            {
               if (num2 == num8)
               {
                  if (num3 == num7)
                  {
                     if (num4 == num6)
                     {
                        Console.WriteLine($"The number {number}  IS a palindrome");
                     }
                     else
                     {
                        Console.WriteLine($"The number {number} IS NOT a palindrome");
                     }
                  }
               }
            }


        }
    }
}
