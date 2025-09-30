/*******************************************************************************
* File		    : V3_DataTypes.cs
* Project	    : Week 01 – C# Fundamentals
* Description	: Demonstrates different data types in C#.
* Author	    : Ridvan Kahraman
* Version	    : v1.0.0
* Date		    : 2025-09-08
* Copyright	    : (c) 2025 Ridvan Kahraman
*******************************************************************************/

using System;

namespace DataTypesApp.Versions
{
    public static class V3_DataTypes
    {
        /// <summary>
        /// Runs the data types example.
        /// </summary>
        public static void Run()
        {
            // Declare variables of different data types
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double num = 3.3;
            bool isMale = true;

            // Print the values of different data types
            Console.WriteLine($"This is string : {phrase}");
            Console.WriteLine($"This is char   : {grade}");
            Console.WriteLine($"This is int    : {age}");
            Console.WriteLine("This is double : " + num);
            Console.WriteLine("This is bool   : " + isMale);
        }
    }
}