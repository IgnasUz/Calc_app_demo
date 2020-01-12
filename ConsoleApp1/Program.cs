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
            //int a = 257;
            //byte b = (byte)a;
            //Console.WriteLine("A is: {0} B is: {1}", a, b);
            Console.WriteLine("Your currnet output is: " + Calculate(3, 7));

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
