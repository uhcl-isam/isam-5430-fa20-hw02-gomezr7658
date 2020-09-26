// University of Houston Clear Lake
// ISAM 5430   Roberto Gomez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an application that reads a bunch of non-negative integers line-by-line until a negative integer or the end-of-line (CTRL-Z) has reached. The app will print out the sum of all the fillers that will make all the values entered so far will appear in increasing order, where each value is larger than the previous number. That is each filler is added to each input, such that the numbers will all appear in increasing order (e.g. 1, 2, 3, 10). The only exception is when the element is 0, where the current number and the subsequent numbers will restart from zero.
    /// </summary>
    /// <param name="a"></param>
    /// <remarks>In essence, this app will calculate the sum of all these values added to the original numbers such that our projected numbers will appear in increasing order.</remarks>
    /// <returns>The sum of all the fillers</returns>
    public class AscendingFillers
    {
        public static void Main()
        {
           Console.WriteLine("Enter a number");
           string input = Console.ReadLine();
           int num = Convert.ToInt32(input);
           int sumFillers = 0;
           int newFiller = 0;
           int startNumber = num;



           num = Convert.ToInt32(Console.ReadLine());

           while (num >= 0 && input != null)
           {

              if (num == 0)
              {
                 startNumber = 0;
              }

              sumFillers = sumFillers + newFiller;
              Console.Error.WriteLine("Enter a number");
              input = Console.ReadLine();
              num = Convert.ToInt32(input);
           }
           Console.WriteLine(sumFillers);
      }
    }
}
