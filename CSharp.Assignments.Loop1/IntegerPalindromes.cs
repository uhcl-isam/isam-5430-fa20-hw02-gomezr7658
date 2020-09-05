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
           int num;
           int sum = 0, t;
           Console.Write("Enter a 9 digits number : ");
           var input = Console.ReadLine();

           while (input != null && (input.Length < 9 || input.Length > 9))
           {
              Console.WriteLine("Please enter a 9 digits number");
              Console.Write("Enter a 9 digits number :");
              input = Console.ReadLine();
           }

           num = Convert.ToInt32(input);

           for (t = num; num != 0; num = num / 10)
           {
              var r = num % 10;
              sum = sum * 10 + r;
           }

           Console.WriteLine(t == sum ? $"{t} is a palindrome number" : $"{t} is not a palindrome");
        }
    }
}
