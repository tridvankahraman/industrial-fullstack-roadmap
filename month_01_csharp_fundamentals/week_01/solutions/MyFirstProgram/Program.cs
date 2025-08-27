// Program.cs
// Week 01 – C# Fundamentals
// Author: Ridvan Kahraman
// Purpose: Entry point of the application, calls example modules.

using System;
using System.Text;
using MyFirstProgram.Versions;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ensure the console supports UTF-8 so emojis display correctly
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            V1_Basics.Run();
            V2_UserInput.Run();

            Console.ReadKey();
        }
    }
}