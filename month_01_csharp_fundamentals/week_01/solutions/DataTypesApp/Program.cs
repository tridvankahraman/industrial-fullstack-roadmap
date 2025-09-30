/*******************************************************************************
* File		    : Program.cs
* Project	    : Week 01 – C# Fundamentals
* Description	: Demonstrates the use of primitive data types in C#.
* Author	    : Ridvan Kahraman
* Version	    : v1.0.0
* Date		    : 2025-09-08
* Copyright	    : (c) 2025 Ridvan Kahraman
**************************************************************************P*****/

using System;
using DataTypesApp.Versions;

namespace DataTypesApp
{
    class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        static void Main(string[] args)
        {
            // Set console title and run different versions
            Console.Title = "Storyteller";
            V1_Basics.Run();
            Console.WriteLine();
            V2_Variables.Run();
            Console.WriteLine();
            V3_DataTypes.Run();
        }
    }
}