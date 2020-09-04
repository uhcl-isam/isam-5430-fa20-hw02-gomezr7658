// University of Houston Clear Lake
// ISAM 5430  Roberto Gomez

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class PositiveInts
    {
        /// <summary>
        /// First prompt for the value of n, then Write all the positive integers up to the integer n on separate lines. [Demonstration]
        /// </summary>
        public static void Main()
        {
           Console.Error.Write("Enter the value of n : ");
           int number = Convert.ToInt32(Console.ReadLine());


           if (number > 0)
           {
              for (int i = 1; i <= number; i++)
              {
                 Console.WriteLine(i);
              }
           }


      }
   }
}
