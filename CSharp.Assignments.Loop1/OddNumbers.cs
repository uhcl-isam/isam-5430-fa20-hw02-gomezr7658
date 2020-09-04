// University of Houston Clear Lake
// ISAM 5430   Roberto Gomez

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
           Console.Error.Write("Enter the starting number: ");
           int start = Convert.ToInt32(Console.ReadLine());

           Console.Error.Write("Enter the ending number: ");
           int end = Convert.ToInt32(Console.ReadLine());

           if (start % 2 != 0)
           {
              for (int i = (start - 2); i < (end - 1); i = i + 2)
              {
                 Console.WriteLine(i + 2);
              }
           }
           else
           {
              for (int i = start; i < end; i = i + 2)
              {
                 Console.WriteLine(i + 1);
              }
           }
        }
   }
}
