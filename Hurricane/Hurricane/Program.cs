using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int windspeed;

            WriteLine("Enter Windspeed");
            windspeed = int.Parse(ReadLine());

            if (windspeed >= 157)
            {
                WriteLine("Cat 5");
            }

            else if (windspeed >= 130 && windspeed < 157)
            {
                WriteLine("Cat 4");
            }

            else if (windspeed >= 111 && windspeed < 130)
            {
                WriteLine("Cat 3");
            }
            else if (windspeed >= 96 && windspeed < 111)
            {
                WriteLine("Cat 2");
            }
            else if (windspeed >= 74 && windspeed < 96)
            {
                WriteLine("Cat 1");
            }
            else
            {
                WriteLine("Not a hurricane");
            }
        }
    }
}
