﻿using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Drivers are concerned with the mileage their automobiles get.
    /// One driver has kept track of several tankfuls of gasoline by 
    /// recording the miles driven and gallons used for each tankful. 
    /// Develop a C# app that will input the miles driven and gallons
    /// used (both as integers) for each tankful. The app should calculate
    /// and display the miles per gallon obtained for each tankful and 
    /// display the combined miles per gallon obtained for all tankfuls
    /// up to this point. All averaging calculations should produce
    /// floating-point results. Display the miles per gallons on one line
    /// and the total miles per gallons on another, both rounded to the
    /// nearest hundredth, immediately after each input. Use the Console
    /// class’s ReadLine method and sentinel-controlled iteration
    /// (e.g. when miles driven are negative, the loop ends) to
    /// obtain the data from the user.
    /// </summary>
    public class GasMileage
    {
        public static void Main()
        {
           {
              int miles = 0;
              var tanks = 1;
              var mpg = 0;
              var totalMpg = 0;

              while (miles != -1)
              {
                 Console.Error.Write("Miles or -1 to stop :");
                 miles = Convert.ToInt32(Console.ReadLine());


                 Console.Error.Write("Gallons :");
                 int gallons = Convert.ToInt32(Console.ReadLine());

                 if (miles == -1)
                    break;

                 tanks++;
                 mpg = miles / gallons;
                 Console.WriteLine($"mpg:  {mpg:f}");
                 Console.WriteLine();
                 totalMpg = totalMpg + mpg;

              }
              Console.WriteLine();
              Console.WriteLine(totalMpg / tanks);
           }
        }
    }
}
