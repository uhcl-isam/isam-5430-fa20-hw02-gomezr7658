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


           Console.Error.Write("Enter a 9 digits number : ");
           var input = Convert.ToInt32(Console.ReadLine());

           if (input >= 100000000 || input <= 999999999)
           {
              
                 int lastInput = 0, left, firstInput;

                 firstInput = input;

                 while (input != 0)
                 {
                    left = input % 10;
                    lastInput = lastInput * 10 + left;
                    input /= 10;
                 }

                 if (firstInput == lastInput)
                    Console.WriteLine(firstInput + " is a palindrome.");
                 else
                    Console.WriteLine(firstInput + " is not a palindrome.");
              
           }
           else
           {
              Console.WriteLine("Not a 9 digits number");
           }


           
        }
    }
}
