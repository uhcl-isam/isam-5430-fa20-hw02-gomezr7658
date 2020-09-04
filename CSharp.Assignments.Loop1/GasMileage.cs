using System;
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
           // initialize variables in declarations
           int totalMiles = 0;
           int totalGallons = 0;
           int tankCounter = 1;
           Boolean anotherOne = true;

           // process information until user enter -1
           while (anotherOne)
           {
              // prompt user for input and obtain value for each tank
              Console.Write($"Enter the number of miles for tank {tankCounter} :  ");
              int miles = int.Parse(Console.ReadLine());
              totalMiles += miles;
              Console.Write($"Enter the number of gallons for tank {tankCounter} :  ");
              int gallons = int.Parse(Console.ReadLine());
              totalGallons += gallons;
              int mpg = miles / gallons;
              Console.WriteLine($"The miles per gallon on this tanks is {mpg:f}");


              Console.Write("Enter the miles for another tank of -1 to finish :  ");
              string answer = Console.ReadLine();
              anotherOne = answer != "-1";
              tankCounter++;
           }

           // termination phase
           // if the user entered at least one tank info..
           if (tankCounter != 0)
           {
              // use number with decimal point to calculate average of grades
              double average = (double)totalMiles / totalGallons;

              // display the total and average (with two digits of precision)
              Console.WriteLine($"The total miles are : {totalMiles:f}");
              Console.WriteLine($"The total gallons are : {totalGallons:f}");


              Console.WriteLine($"MPG is {average:f}");
           }
      }
    }
}
