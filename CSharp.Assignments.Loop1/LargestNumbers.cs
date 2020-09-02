// University of Houston Clear Lake
// ISAM 5430    Roberto Gomez

using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The process of finding the maximum value (i.e., the largest
    /// of a group of values) is used frequently in computer applications.
    /// For example, an app that determines the winner of a sales contest
    /// would input the number of units sold by each salesperson. The
    /// salesperson who sells the most units wins the contest.
    /// Write pseudocode, then a C# app that inputs a series of 10 integers,
    /// then determines and displays the largest integer followed by the
    /// second largest integer.
    /// Your app should use at least the following four variables:
    ///     counter: A counter to count to 10 (i.e., to keep track of
    ///        how many numbers have been input and to determine when all
    ///        10 numbers have been processed).
    ///     number (integer): The integer most recently input by the user.
    ///     largest: The largest number found so far.
    ///     largest2: The second largest number found so far.
    /// </summary>
    public class LargestNumbers
    {
        public static void Main()
        {
           // Declaring and initializing variables
           int largest = 0;  // This hold the largest result
           int largest2 = 0;

           // get first number and assign it to variable largest
           Console.Write("Enter the number:  ");
           largest = Convert.ToInt32(Console.ReadLine());

           // get second number and assign to number
           Console.Write("Enter the next number:  ");
           int number = Convert.ToInt32(Console.ReadLine());

           // compare both to find the largest
           if (number > largest)
           {
              largest2 = largest;
              largest = number;
           }
           else
           {
              largest2 = number;
           }

           // continue checking the numbers
           for (int i = 3; i <= 10; i++)
           {
              Console.Write("Enter the next number: ");
              number = Convert.ToInt32(Console.ReadLine());
              // compare with the largest and second largest
              if (number > largest)
              {
                 largest2 = largest;
                 largest = number;
              }
              else if (number > largest2)
              {
                 largest2 = number;
              }
           }

           // Results
           Console.WriteLine($"The largest number is {largest}");
           Console.WriteLine($"The second largest number is {largest2}");
           



        }
    }
}
