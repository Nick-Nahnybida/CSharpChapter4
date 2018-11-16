using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Age_Insult_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int choice;

            WriteLine("Enter your age");
            userInput = int.Parse(ReadLine());

            if (userInput <= 18) 
            {
                WriteLine("Where are you parents? Go to bed.");
            }
            else if (userInput > 18 && userInput <= 25)
            {
                WriteLine("Are you in your parents' basement?");
            }
            else if (userInput > 25 && userInput <= 32)
            {
                WriteLine("Shouldn't you be working or something?");
            }
            else if (userInput > 32 && userInput <= 42)
            {
                WriteLine("How's that family coming huh?");

            }
            else if (userInput > 42 && userInput <= 52)
            {
                WriteLine("Mid life crisis coming shortly");
            }
            else if (userInput > 52 && userInput <= 62)
            {
                WriteLine("Is retirement even in sight?");
                WriteLine("Are you retired yet? 1 for yes. 2 for no.");
                choice = int.Parse(ReadLine());
                if (choice == 1)
                {
                    WriteLine("Enjoy wittling down your nest egg");
                }
                else if(choice == 2)
                {
                    WriteLine("Hope you are building your nest egg.");
                }
            }
            else if (userInput > 62)
            {
                WriteLine("How many pills a day are you up to?");
            }
        }
    }
}
