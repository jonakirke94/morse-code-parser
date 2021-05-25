using System;
using System.Collections.Generic;

namespace MorseCodeParser
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Morse Code Parser");

            Console.WriteLine("Input a morse code string consiting of '.-/ ' where / is separating words");

            Console.WriteLine("For example '.... . .-.. .--.' outputs 'help'");


            var parser = new MorseTree();

            while (true)
            {
                var input = Console.ReadLine();

                var parsedStr = parser.Parse(input);

                Console.WriteLine("\n******************\n");
                Console.WriteLine("Parsed: " + parsedStr);
                Console.WriteLine("\nEnter a new string to be parsed:");
            }                       
        }   
    }
}
