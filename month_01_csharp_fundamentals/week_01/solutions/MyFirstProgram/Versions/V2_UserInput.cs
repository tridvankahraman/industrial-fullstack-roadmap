/*******************************************************************************
* File		    : V2_UserInput.cs
* Project	    : Week 01 – C# Fundamentals
* Description	: Asks the user for their name and greets them.
* Author	    : Ridvan Kahraman
* Version	    : v1.0.0
* Date		    : 2025-09-08
* Copyright	    : (c) 2025 Ridvan Kahraman
*******************************************************************************/

using System;

namespace MyFirstProgram.Versions
{
    public static class V2_UserInput
    {
        /// <summary>
        /// Runs the user input example.
        /// </summary>
        public static void Run()
        {
            // Ask the user for their name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine() ?? "Guest";

            // Greet the user with their name
            Console.WriteLine($"Hello {name}! 👋");
            Console.WriteLine("Welcome to our Fullstack journey! 🚀");
        }
    }
}