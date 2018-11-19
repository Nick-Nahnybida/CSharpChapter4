using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NumberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            

            WriteLine("Enter a number; 1, 2, or 3");
            userInput = int.Parse(ReadLine());

            if (userInput == 1 || userInput == 3)
            {
                WriteLine("You have lost");
            }
            else if (userInput == 2)
            {
                WriteLine("You win!");
            }
            else if (userInput >= 3)
            {
                WriteLine("Error");
            }
        }
    }
}
