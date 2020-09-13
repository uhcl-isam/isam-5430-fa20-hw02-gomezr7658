// University of Houston Clear Lake
// ISAM 5430  Roberto Gomez

using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app that requires two inputs:
    /// the number of rows/columns and the fill character (char).
    /// The app will then provide output statements to display the
    /// checkerboard pattern that follows. A Console.WriteLine method
    /// call with no arguments outputs a single newline character. 
    /// [Hint: Iteration statements are required.]
    /// <example>
    /// For 8 rows and a fill character of '*', the app will produce
    ///  an 8 by 8 checkerboard as follows:
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// </example>
    /// </summary>
    public class CheckerboardPattern
    {
       public static void Main()
       {
          // Write your codes here.
          Console.Write("Enter the number of rows:  ");
          int num = int.Parse(Console.ReadLine());
          Console.Write("Enter the fill character:  ");
          char fillCharacter = Char.Parse(Console.ReadLine());

          int row = 1;
          while (row <= num)
          {
             int column = 1;

             if (row % 2 == 0)
             {
                Console.Write(" ");
             }

             while (column <= num)
             {
                Console.Write(fillCharacter); 
                Console.Write(" ");
                ++column;
             }

             Console.WriteLine();
             ++row;
          }

       }
    }
}
