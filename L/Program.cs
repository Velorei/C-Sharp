namespace L;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Variables:");
        Console.WriteLine("int - stores integers (whole numbers), without decimals");
        Console.WriteLine("double - stores floating point numbers, with decimals");
        Console.WriteLine("char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes");
        Console.WriteLine("string - stores text, such as \"Hello World\". String values are surrounded by double quotes");
        Console.WriteLine("bool - stores values with two states: true or false");
        string name = "John";
        Console.WriteLine(name);
        int myNum = 15;
        Console.WriteLine(myNum);
        int myNum1 = 15;
        myNum1 = 20; // myNum is now 20
        Console.WriteLine(myNum1);
        int myNum3;
        myNum3 = 15;
        Console.WriteLine(myNum3);
        int myNum4 = 5;
        double myDoubleNum = 5.99D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";
        const int myNum5 = 15;
        myNum = 20; // error
    }
}

