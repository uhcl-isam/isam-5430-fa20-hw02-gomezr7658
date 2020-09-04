using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The Main app will prompt the user for the last number of the Fibonacci numbers.
    /// Then, the app will write a sequence of numbers in a Fibonacci sequence up to the last number.
    /// Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, 
    /// and characterized by the fact that every number after the first two is the sum of the two preceding ones.
    /// The first two numbers are 0 and 1 so the numbers will be 0 1 1 2 3 5 8 13 21 34 55 89...
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main()
        {
           int nextNumber = 1;
           int current = 0;

           Console.Write("Enter the last number of Fibonacci Sequence of numbers :  ");
           int end = int.Parse(Console.ReadLine());

           Console.WriteLine(current);

           if (end > 0)
           {
              //Console.WriteLine(nextNumber);

              while (nextNumber <= end)
              {
                 // Calculate next number
                 var result = current + nextNumber;
                 Console.WriteLine(nextNumber);
                 current = nextNumber;
                 nextNumber = result;

              }
           }


        }
   }
}
