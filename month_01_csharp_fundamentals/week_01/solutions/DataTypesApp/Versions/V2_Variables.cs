// V2_Variables.cs
// Week 01 – C# Fundamentals
// Author: Ridvan Kahraman
// Purpose: Prints a basic short story to console using variables.

using System;

namespace DataTypesApp.Versions
{
    public static class V2_Variables
    {
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