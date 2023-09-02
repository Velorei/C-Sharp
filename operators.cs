using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 100 + 50;
            Console.WriteLine(k);

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);


            /*Arithmetic operators are used to perform common mathematical operations:

            +	Addition	Adds together two values	x + y	
            -	Subtraction	Subtracts one value from another	x - y	
            *	Multiplication	Multiplies two values	x * y	
            /	Division	Divides one value by another	x / y	
            %	Modulus	Returns the division remainder	x % y	
            ++	Increment	Increases the value of a variable by 1	x++	
            --	Decrement	Decreases the value of a variable by 1	x-- */


            /*Assignment operators are used to assign values to variables.*/
            /*A list of all assignment operators:

            =	x = 5	x = 5	
            +=	x += 3	x = x + 3	
            -=	x -= 3	x = x - 3	
            *=	x *= 3	x = x * 3	
            /=	x /= 3	x = x / 3	
            %=	x %= 3	x = x % 3	
            &=	x &= 3	x = x & 3	
            |=	x |= 3	x = x | 3	
            ^=	x ^= 3	x = x ^ 3	
            >>=	x >>= 3	x = x >> 3	
            <<=	x <<= 3	x = x << 3 */

            /*Comparison Operators */
            int x = 5;
            int y = 3;
            Console.WriteLine(x > y); // returns True because 5 is greater than 3

            /*A list of all comparison operators:

            ==	Equal to	x == y	
            !=	Not equal	x != y	
            >	Greater than	x > y	
            <	Less than	x < y	
            >=	Greater than or equal to	x >= y	
            <=	Less than or equal to	x <= y */

            /*Logical Operators
            As with comparison operators, you can also test for True or False values with logical operators.

            Logical operators are used to determine the logic between variables or values:

            && 	Logical and	Returns True if both statements are true	x < 5 &&  x < 10	
            || 	Logical or	Returns True if one of the statements is true	x < 5 || x < 4	
            !	Logical not	Reverse the result, returns False if the result is true	!(x < 5 && x < 10) */

}
}
}
