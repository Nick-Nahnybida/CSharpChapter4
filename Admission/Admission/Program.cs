using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            double Accepted;
            double testScore;

            WriteLine("Enter GPA");
            gpa = Double.Parse(ReadLine());

            WriteLine("Enter Test Score");
            testScore = Double.Parse(ReadLine());

            if (gpa >= 3.0 && testScore >= 60)
            {
                Write("Accept");
            }
            else if (gpa <= 3.0 && testScore >= 80)
            {
                Write("Accept");
            }
            else
            {
                Write("Reject");
            }
        }
    }
}
