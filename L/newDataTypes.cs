using System;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace MyApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;               // integer (whole number)
            double myDoubleNum = 5.99D;  // floating point number
            char myLetter = 'D';         // character
            bool myBool = true;          // boolean
            string myText = "Hello";     // string
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            int myNum1 = 100000;
            Console.WriteLine(myNum1);


            /*int 4 bytes Stores whole numbers from - 2,147,483,648 to 2,147,483,647
            long    8 bytes Stores whole numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float   4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double  8 bytes Stores fractional numbers.Sufficient for storing 15 decimal digits
            bool    1 bit   Stores true or false values
            char    2 bytes Stores a single character / letter, surrounded by single quotes
            string  2 bytes per character   Stores a sequence of characters, surrounded by double quotes*/

            int myNum2 = 100000;
            Console.WriteLine(myNum2);

            long myNum3 = 15000000000L;
            Console.WriteLine(myNum3);

            float myNum4 = 5.75F;
            Console.WriteLine(myNum4);

            double myNum5 = 19.99D;
            Console.WriteLine(myNum5);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            char myGrade = 'B';
            Console.WriteLine(myGrade);

            string greeting = "Hello World";
            Console.WriteLine(greeting);
        }
    }
}
