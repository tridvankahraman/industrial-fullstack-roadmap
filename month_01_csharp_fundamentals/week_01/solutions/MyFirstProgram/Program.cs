/*******************************************************************************
* File		    : Program.cs
* Project	    : Week 01 – C# Fundamentals
* Description	: Entry point of the application, calls example modules.
* Author	    : Ridvan Kahraman
* Version	    : v1.0.0
* Date		    : 2025-09-08
* Copyright	    : (c) 2025 Ridvan Kahraman
*******************************************************************************/

using System;
using System.Text;
using MyFirstProgram.Versions;

namespace MyFirstProgram
{
    class Program
    {
        /// <summary>
        /// Main entry point of the application.
        /// Calls different example modules.
        /// </summary>
        /// <param name="args">Command-line arguments (not used).</param>
        static void Main(string[] args)
        {
            // Ensure the console supports UTF-8 so emojis display correctly
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            V1_Basics.Run(); // Basic "Hello World" example
            V2_UserInput.Run(); // User input example
        }
    }
}