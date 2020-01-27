using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Calculate(int input1, int input2)
        {
            int number = input1 + input2;
            return number;
        }

        static void Main(string[] args)
        {
            //Random calculations
            Console.WriteLine("Your 1st output is: " + Calculate(3, 7));

            Console.WriteLine("Your 2nd output is: " + Calculate(5, 5));

            Console.WriteLine("Your 3rd output is: " + Calculate(10, 10));


        }
    }
}
