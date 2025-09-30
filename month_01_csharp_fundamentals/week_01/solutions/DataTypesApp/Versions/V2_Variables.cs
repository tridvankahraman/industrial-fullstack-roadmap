/*******************************************************************************
* File		    : V2_Variables.cs
* Project	    : Week 01 – C# Fundamentals
* Description	: Prints a basic short story to console using variables.
* Author	    : Ridvan Kahraman
* Version	    : v1.0.0
* Date		    : 2025-09-08
* Copyright	    : (c) 2025 Ridvan Kahraman
*******************************************************************************/

using System;

namespace DataTypesApp.Versions
{
    public static class V2_Variables
    {
        /// <summary>
        /// Runs the basic short story example using variables.
        /// </summary>
        public static void Run()
        {
            string characterName = "Jack";
            int characterAge = 80;

            // Print the four-line story
            Console.WriteLine($"There once was a man named {characterName}.");
            Console.WriteLine("He was " + characterAge + " years old.");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName + ".");
            Console.WriteLine($"But didn't like being {characterAge}.");
        }
    }
}