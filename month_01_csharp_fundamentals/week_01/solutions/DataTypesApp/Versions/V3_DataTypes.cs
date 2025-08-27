// V3_DataTypes.cs
// Week 01 – C# Fundamentals
// Author: Ridvan Kahraman
// Purpose: Prints a basic short story to console.

using System;

namespace DataTypesApp.Versions
{
    public static class V3_DataTypes
    {
        public static void Run()
        {
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double num = 3.3;
            bool isMale = true;

            Console.WriteLine($"This is string : {phrase}");
            Console.WriteLine($"This is char   : {grade}");
            Console.WriteLine($"This is int    : {age}");

            Console.WriteLine("This is double : " + num);
            Console.WriteLine("This is bool   : " + isMale);
        }
    }
}