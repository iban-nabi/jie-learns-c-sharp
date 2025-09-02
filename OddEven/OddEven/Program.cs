using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            if (num2==0)
            {
                Console.WriteLine(num1+" is even!");
            }

            Console.WriteLine(num2 + " is odd!");
            Console.ReadLine();

        }
    }
}
