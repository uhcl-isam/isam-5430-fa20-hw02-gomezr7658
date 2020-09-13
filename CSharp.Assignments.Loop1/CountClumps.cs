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
          int num = 1;
          string second = null;

          // Write your codes here
          Console.WriteLine("Enter the first integer");
          Console.WriteLine("Type CTLR Z and press Enter to terminate input: ");
          string first = Console.ReadLine();

          Console.WriteLine("Enter the second integer");
          Console.WriteLine("Type CTLR Z and press Enter to terminate input: ");
          second = Console.ReadLine();


         while (first != null)
          {
             if (second == first && num == 1)
             {
                count++;
                num++;
             }
             else
             {
                num = 1;
             }

             first = second;
             
             Console.WriteLine("Enter next integer");
             Console.WriteLine("Type CTLR Z and press Enter to terminate input: ");
             second = Console.ReadLine();
          }
          Console.WriteLine(count);
       }
    }
}
