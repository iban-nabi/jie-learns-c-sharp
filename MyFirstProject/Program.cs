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



            // text data types
            string myFriend = "aba";
            char letter = 'A';

            Console.WriteLine(myFriend);   
            Console.WriteLine(letter);


            //convert string to numeric data
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string bigNumber = "-90000000";
            long bigNumber = Convert.ToInt64(bigNumber);
            Console.WriteLine(bigNumber);

            string negativeString = "-1.24";
            double negative = Convert.ToDouble(negativeString);
            Console.WriteLine(negative);

            string precisionString = "5.99";
            float precision = Convert.ToSingle(precisionString);
            Console.WriteLine(precision);

            string moneyString = "5.60";
            decimal money = Convert.ToDecimal(moneyString);
            Console.WriteLine(moneyString);

            Console.ReadLine();
        }
    }
}
