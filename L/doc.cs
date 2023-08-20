using System;

namespace MyApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            string name = "John";
            Console.WriteLine("Hello " + name);

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            int a = 5, z = 6, w = 50;
            Console.WriteLine(a + z + w);

            int b, c, d;
            b = c = d = 50;
            Console.WriteLine(b + c + d);

        }
    }
}
