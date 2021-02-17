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

            //value type holds the value directly on its own memory space
            //uses a heap to store the value
            //value types: int, float, long, double, char, bool, decimal, double, etc.

            //reference type is a variable that stores memory location of the actual data
            //stores memory reference of the data and not the actual data
            //string, class, array, etc. typically need more space and saves space

            //Console.Write("hello"); //prints and keeps the cursor on the same line
            //Console.WriteLine("hello from here~"); //prints and puts cursor on the next line
            //Console.Read(); //takes a single input of type string and returns ASCII value of that input
            ////ASCII code is computer interpretation of characters, 256 values
            //Console.ReadLine(); //takes a string or int and returns it as the Output value
            //Console.ReadKey(); //takes a single input of type string and returns key info

            Console.Write("Enter a letter and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a letter and press enter: ");
            int asciiVal = Console.Read();
            Console.Write("ASCII value is {0}", asciiVal);
            Console.ReadKey();
        }
    }
}
