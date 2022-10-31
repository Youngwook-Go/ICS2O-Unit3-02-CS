// Created by: Youngwook
// Created on: OCT 2022
//
// This function gets volume of pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        //this function accept user input
        double baseLength;
        double baseWidth;
        double heightLength;
        double result;

        Console.WriteLine("This program gets volume of pyramid.");
        Console.WriteLine("Please enter the value of the pyramid.\n");
        Console.Write("Enter value of base length : "); baseLength = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of base width : "); baseWidth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of height length : "); heightLength = Convert.ToInt32(Console.ReadLine());

        result = (baseLength * baseWidth * heightLength) / 3;

        //this function prints the result
        Console.WriteLine("\nVolume of the pyramid is : " + result.ToString("0.00") + " cm² ");
        Console.WriteLine("\ndone.");
    }
}