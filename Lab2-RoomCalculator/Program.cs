using System;
using System.Collections.Generic;

namespace Lab2_RoomCalculator
{
    /*
    Author:   Jeffrey Wohlfield
    Date  01-19-2021

    This program will prompt for length and width dimensions of a room and use them to calculate the area and perimeter of the room.
    
    Build Specifications:
     Assume that the rooms are perfect rectangles.
     Assume that the user will enter valid numeric data for length and width.
     The application should accept decimal entries.
*/
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y";
            List<Dimension> dimensions = new List<Dimension>();

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            while (proceed == "y")
            {
                // Get user input for Length
                Console.Write("\nEnter Length: ");
                double length = double.Parse(Console.ReadLine());

                // Get user input for Width
                Console.Write("Enter Width: ");
                double width = double.Parse(Console.ReadLine());

                // Get user input for Height
                Console.Write("Enter Height: ");
                double height = double.Parse(Console.ReadLine());


                // Display Area & Perimeter
                dimensions.Add(new Dimension(length, width, height));
                //Console.WriteLine($"Area: {Math.Round((length * width), 2)}");
                //Console.WriteLine($"Perimeter: {Math.Round(2 * (length + width), 2)}");
                //Console.WriteLine($"Volume: {Math.Round(length * width * height, 2)}");

                // Ask if user wants to continue
                Console.Write("\nContinue? (y/n) ");
                proceed = Console.ReadLine();

            }
            
        }
    }
}
