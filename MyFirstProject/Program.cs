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
            int myAge = 23;
            Console.WriteLine("My name is "+ name + "and I am "+ myAge + "years old");

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

            string bigNumberString = "-90000000";
            long bigNumberConverted = Convert.ToInt64(bigNumberString);
            Console.WriteLine(bigNumberConverted);

            string negativeString = "-1.24";
            double negativeConverted = Convert.ToDouble(negativeString);
            Console.WriteLine(negativeConverted);

            string precisionString = "5.99";
            float precisionConverted = Convert.ToSingle(precisionString);
            Console.WriteLine(precisionConverted);

            string moneyString = "5.60";
            decimal moneyConverted = Convert.ToDecimal(moneyString);
            Console.WriteLine(moneyConverted);


            //boolean data type
            bool trueValue = true;
            bool falseValue = false;
            Console.WriteLine(trueValue);   
            Console.WriteLine(falseValue);

            bool isMale = true;
            bool isFalse = false;
            Console.WriteLine(isMale);
            Console.WriteLine(isFalse);


            // operations
            int newAge = 23; 
            Console.WriteLine(newAge++);
            Console.Write(newAge--);


            Console.WriteLine(newAge * 3);

            double numWithDecimal = 15.0;
            Console.WriteLine(numWithDecimal/2);

            int i = 0;
            Console.WriteLine(++i);
            Console.WriteLine(i++);


            // variable
            var brother = "Joe";

            // constant
            const string dogName = "Sky";


            const int vat = 20;
            const double percentVAT = vat / 100D;
            int balance = 1000;

            Console.WriteLine(balance * percentVAT);




            Console.ReadLine();
        }
    }
}
