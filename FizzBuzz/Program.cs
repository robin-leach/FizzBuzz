using System;
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
            Console.WriteLine("Enter maximum (between 1 and 1000): ");
            string input = Console.ReadLine();
            int MAX;
            bool success = Int32.TryParse(input, out MAX);
            if (success && MAX >= 1 && MAX <= 1000)
            {
                for (int i = 1; i <= MAX; i++) // Run i through the numbers 1 to 100
                {
                    string output = "";     // Start with an empty string, called output
                    if (i % 17 != 0)        // If i is not divisible by 17 do the normal way around
                    {
                        if (i % 3 == 0)
                        {
                            output += "Fizz";   // If i is divisible by 3, append "Fizz" to output
                        }
                        if (i % 5 == 0)
                        {
                            output += "Buzz";    // If i is divisible by 5, append "Buzz" to output
                        }
                        if (i % 7 == 0)
                        {
                            output += "Bang";     // If i is divisible by 7, append "Bang" to output
                        }
                        if (i % 11 == 0)
                        {
                            output = "Bong";      // If i is divisible by 11, replace output with "Bong"
                        }
                        if (i % 13 == 0)
                        {
                            output = "Fezz" + output;   // If i is divisible by 13, add "Fezz" to the start of output
                        }
                    }
                    else // If it's divisible by 17 do the reverse
                    {
                        if (i % 3 == 0)
                        {
                            output = "Fizz" + output;   // If i is divisible by 3, add "Fizz" to the start of output
                        }
                        if (i % 5 == 0)
                        {
                            output = "Buzz" + output;    // If i is divisible by 5, add "Buzz" to the start of output
                        }
                        if (i % 7 == 0)
                        {
                            output = "Bang" + output;     // If i is divisible by 7, add "Bang" to the start of output
                        }
                        if (i % 11 == 0)
                        {
                            output = "Bong";      // If i is divisible by 11, replace with "Bong"
                        }
                        if (i % 13 == 0)
                        {
                            output += "Fezz";   // If i is divisible by 13, append "Fezz"
                        }
                    }

                    if (output == "")
                    {
                        Console.WriteLine(i); // If the string is still empty just print the number
                    }
                    else
                    {
                        Console.WriteLine(output);  //...otherwise print the string itself
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid maximum");
            }
            Console.ReadLine();
        }
    }
}
