/*******************************************************************************
* File		    : V1_Basics.cs
* Project	    : Week 01 – C# Fundamentals
* Description	: Prints a basic short story to console.
* Author	    : Ridvan Kahraman
* Version	    : v1.0.0
* Date		    : 2025-09-08
* Copyright	    : (c) 2025 Ridvan Kahraman
*******************************************************************************/

using System;

namespace DataTypesApp.Versions
{
    public static class V1_Basics
    {
        /// <summary>
        /// Runs the basic short story example.
        /// </summary>
        public static void Run()
        {
            // Print the four-line story
            Console.WriteLine("There once was a man named John.");
            Console.WriteLine("He was 70 years old.");
            Console.WriteLine("He really liked the name John.");
            Console.WriteLine("But didn't like being 70.");
        }
    }
}