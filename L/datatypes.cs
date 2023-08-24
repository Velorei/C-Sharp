using System;

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


            int 4 bytes Stores whole numbers from - 2,147,483,648 to 2,147,483,647
            long    8 bytes Stores whole numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float   4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double  8 bytes Stores fractional numbers.Sufficient for storing 15 decimal digits
            bool    1 bit   Stores true or false values
            char    2 bytes Stores a single character / letter, surrounded by single quotes
            string  2 bytes per character   Stores a sequence of characters, surrounded by double quotes
        }
    }
}
