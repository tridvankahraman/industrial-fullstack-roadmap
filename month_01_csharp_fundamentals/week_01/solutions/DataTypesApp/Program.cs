// Program.cs
// Week 01 – C# Fundamentals
// Author: Ridvan Kahraman
// Purpose: Demonstrates the use of primitive and reference data types in C#.

using System;
using DataTypesApp.Versions;

namespace DataTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Storyteller";
            V1_Basics.Run();
            Console.WriteLine();
            V2_Variables.Run();
            Console.WriteLine();
            V3_DataTypes.Run();

            Console.ReadKey();
        }
    }
}