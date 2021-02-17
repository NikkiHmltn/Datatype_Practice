using System;

namespace Datatype_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 12;
            int num3 = num1 + num2;
            int num4;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + num3);
            

            double d1 = 3.5;
            double d2 = 1.337;
            double sumd = d1 + d2;

            num4 = 15;
            Console.WriteLine(num4);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumd);

            float f1 = 3.5f;
            float f2 = 2.5f;
            float sumF = f2 + f1;
            Console.WriteLine(sumF);

            string myname = "Nikki";
            string message = "My name is " + myname;
            string capsMsg = message.ToUpper();
            string lowerMsg = message.ToLower();
            Console.WriteLine(message);
            Console.WriteLine(capsMsg);
            Console.WriteLine(lowerMsg);
        }
    }
}
