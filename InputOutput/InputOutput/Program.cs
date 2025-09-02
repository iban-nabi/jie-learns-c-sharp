using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, what is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("So your name is " + name + "!");
            Console.Write("So " + name + ", how old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So you are " + age + " years old");
            Console.WriteLine("Nice meeting you " + name + ". Have a great day!");
            Console.ReadLine();
        }
    }
}
