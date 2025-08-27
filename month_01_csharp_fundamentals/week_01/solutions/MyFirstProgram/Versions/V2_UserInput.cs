// V2_UserInput.cs
// Week 01 – C# Fundamentals
// Author: Ridvan Kahraman
// Purpose: Asks the user for their name and greets them.

using System;

namespace MyFirstProgram.Versions
{
    public static class V2_UserInput
    {
        public static void Run()
        {
            // Ask the user for their name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine() ?? "Guest";

            // Greet the user
            Console.WriteLine($"Hello {name}! 👋");
            Console.WriteLine("Welcome to our Fullstack journey! 🚀");
        }
    }
}