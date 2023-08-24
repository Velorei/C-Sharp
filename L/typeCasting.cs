using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            /*In C#, there are two types of casting:
            Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char
            */
            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9

            /*It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):*/

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}
