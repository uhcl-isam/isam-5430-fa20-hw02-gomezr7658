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
           int digit1 = 0;
           int digit2 = 0;
           int digit3 = 0;
           int digit4 = 0; 
           int digit5 = 0;
           int digit6 = 0; 
           int digit7 = 0;
           int digit8 = 0; 
           int digit9 = 0;
           string sol = null;

           Console.Error.Write("Enter a 9 digits number : ");
           var input = Convert.ToInt32(Console.ReadLine());

           if (input > 100000000 || input < 999999999)
           {
              digit1 = input / 100000000;
              digit2 = (input % 100000000) / 10000000;
              digit3 = (input % 10000000) / 1000000;
              digit4 = (input % 1000000) / 100000;
              digit5 = (input % 100000) / 10000;
              digit6 = (input % 10000) / 1000;
              digit7 = (input % 1000) / 100;
              digit8 = (input % 100) / 10;
              digit9 = (input % 10);

           }

           if (digit1 == digit9)
           {
              if (digit2 == digit8)
              {
                 if (digit3 == digit7)
                 {
                    if (digit4 == digit6)
                    {
                       sol = "palindrome";
                    }
                 }
              }
           }
           else
           {
              sol = "not palindrome";
           }

           Console.WriteLine(sol);

           
        }
    }
}
