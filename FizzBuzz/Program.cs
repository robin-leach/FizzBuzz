﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 301; i++) // Run through the numbers 1 to 100
            {
                string output = "";     // Start with an empty string
                if (i % 3 == 0)
                {
                    output += "Fizz";   // If the number is divisible by 3, add "Fizz"
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";    // If the number is divisible by 5, add "Buzz"
                }
                if (i % 7 == 0)
                {
                    output += "Bang";     // If the number is divisible by 7, add "Bang"
                }
                if (i % 11 == 0)
                {
                    output = "Bong";      // If the number is divisible by 11, replace with "Bong"
                }
                if (i % 13 == 0)
                {
                    output = "Fezz" + output;   // If the number is divisible by 13, print "Fezz" and then the string, even in the 11 case
                }
                if(output == "")
                {
                    Console.WriteLine(i); // If the string is still empty just print the number
                }
                else
                {
                    Console.WriteLine(output);  //...otherwise print the string itself
                }
            }
            Console.ReadLine();
        }
    }
}
