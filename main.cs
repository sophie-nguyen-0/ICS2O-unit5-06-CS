// Created by: sophie
// Created on: dec 2020
//
// This program does loops and math

using System;

class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        int num1;
        int num2;
        int sum = 0;

        Console.WriteLine("this program does multiplication with while loops");

        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("multiplied by: ");
        num2 = Convert.ToInt32(Console.ReadLine());
      

        while (count < num2)
        {
            sum += num1;
            count++;
        }
        Console.WriteLine("your answer is: " + sum + ".");
        Console.WriteLine("\nDone.");
    }
}