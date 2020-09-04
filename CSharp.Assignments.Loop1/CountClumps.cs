// University of Houston Clear Lake
// ISAM 5430   Roberto Gomez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunch of integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
           int count = 0;

           // Write your codes here
           Console.WriteLine("Enter the first integer");
           Console.WriteLine("Type CTLR Z and press Enter to terminate input: ");
           string first = Console.ReadLine();

           Console.WriteLine("Enter the second integer");
           Console.WriteLine("Type CTLR Z and press Enter to terminate input: ");
           string next = Console.ReadLine();


           while (next != null)
           {
              if (first == next)
              {
                 count++;
              }
              else
              {
                 first = next;
              }
              Console.WriteLine("Enter next number: ");
              next = Console.ReadLine();
           }

           Console.WriteLine($"Count : {count}");

        }
   }
}
