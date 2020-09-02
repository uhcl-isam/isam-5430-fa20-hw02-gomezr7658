// University of Houston Clear Lake
// ISAM 5430   Roberto Gomez

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app reads two inputs: a character that indicates which pattern to choose ('a' = lower left triangle, 'b' = upper left triangle, 'c' = upper right triangle, 'd' = lower right triangle) and an integer that indicates the number of lines to display. The app will then display the following patterns separately, one below the other. Use for loops to generate patterns. All asterisks (*) should be displayed by a signle statement of the form Console.Write('*'); which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line. A statement of the form COnsole.Write(' '); can be used to display a space for the last two patterns., There should be no other output statements in the app. [Hint: the last two patterns require that each line begin with an appropriate number of blank spaces.
    /// </summary>
    /// <example>
    ///    (a)          (b)         (c)          (d)
    /// *           **********  **********           *
    /// **          *********    *********          **
    /// ***         ********      ********         ***
    /// ****        *******        *******        ****
    /// *****       ******          ******       *****
    /// ******      *****            *****      ******
    /// *******     ****              ****     *******
    /// ********    ***                ***    ********
    /// *********   **                  **   *********
    /// **********  *                    *  **********
    /// </example>
    public class DisplayTriangle
    {
        public static void Main()
        {
            Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
            char t = Convert.ToChar(Console.ReadLine());
            Console.Error.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());

         // Write your codes here.

         switch (t)
         {
            case 'a':
               for (int i = 0; i < n; i++)
               {
                  for (int j = 0; j < (i + 1); j++)
                  {
                     Console.Write("*");
                  }
                  Console.WriteLine("");
               }
               break;
            case 'b':
               for (int i = 0; i < n; i++)
               {
                  for (int j = (n - i); j > 0; j--)
                  {
                     Console.Write("*");
                  }

                  Console.WriteLine("");
               }
               break;
            case 'c':
               for (int i = 0; i < n; i++)
               {
                  for (int k = 0; k < i; k++)
                  {
                     Console.Write(" ");
                  }
                  for (int j = (n - i); j > 0; j--)
                  {
                     Console.Write("*");
                  }
                  Console.WriteLine("");
               }
               break;
            case 'd':
               for (int i = 1; i <= n; i++)
               {
                  for (int k = (n - i); k > 0; k--)
                  {
                     Console.Write(" ");
                  }
                  for (int j = 0; j < i; j++)
                  {
                     Console.Write("*");
                  }
                  Console.WriteLine("");
               }
               break;
            default:
               break;
         }
         Console.ReadLine();
        }
    }
}
