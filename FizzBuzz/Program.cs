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
            for (int i = 1; i < 101; i++) // Run through the numbers 1 to 100
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
                if(output == "")
                {
                    Console.WriteLine(i); // If the string is still empty (i.e. not div'ble by 3 or 5) just print the number
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
