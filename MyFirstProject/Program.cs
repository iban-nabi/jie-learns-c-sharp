using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            string name = "Ivan";

            // numeric data types
            int age = 23;
            Console.WriteLine("My name is "+ name + "and I am "+ age +"years old");

            long bigNumber = 10000L;

            Console.WriteLine("This is a long number: " + bigNumber);

            Console.WriteLine("This is the largest int " + int.MaxValue);
            Console.WriteLine("This is the smallest int " + int.MinValue);
            Console.WriteLine("This is the largest long " + long.MaxValue);
            Console.WriteLine("This is the smallest long " + long.MinValue);

            double negative = -1.24;
            double positive = 5.0;

            Console.WriteLine(negative);
            Console.WriteLine(positive);

            float precision = 5.99F;
            Console.WriteLine("This is a float: "+precision);

            decimal money = 14.99M;
            Console.WriteLine(money);

            int x = 10, 
                y = 20,
                z = 30;

            Console.WriteLine(x);
            Console.Write(y);
            Console.WriteLine(z);

            Console.ReadLine();

            // text data types

        }
    }
}
