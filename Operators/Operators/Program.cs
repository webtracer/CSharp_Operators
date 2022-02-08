using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine($"Num3 = {num3}");

            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}");  // the ! is a negative/false

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Num = {num++}");  // Doesn't increment until next iteration
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Num = {++num}"); //increments before iteration

            //decriment operator
            num--;
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Num = {num--}");  // Doesn't decrement until next iteration
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Num = {--num}"); //decrements before iteration

            // multiply, divide add, subtract
            int result;
            result = num1 + num2;
            Console.WriteLine($"The result of {num1} + {num2} is {result}");

            result = num1 - num2;
            Console.WriteLine($"The result of {num1} - {num2} is {result}");

            result = num1 * num2;
            Console.WriteLine($"The result of {num1} * {num2} is {result}");

            result = num1 / num2;
            Console.WriteLine($"The result of {num1} / {num2} is {result}");

            result = num1 % num2;
            Console.WriteLine($"The result of {num1} % {num2} is {result}");

            // relational and type operators
            bool isLower;

            isLower = num1 < num2;
            Console.WriteLine($"Result of {num1} < {num2} is {isLower}");

            isLower = num1 > num2;
            Console.WriteLine($"Result of {num1} > {num2} is {isLower}");

            bool isEqual;

            isEqual = num1 == num2;
            Console.WriteLine($"Result of {num1} == {num2} is {isEqual}");

            isEqual = num1 != num2;
            Console.WriteLine($"Result of {num1} != {num2} is {isEqual}");

            // Conditional Operators / Logic Operators
            bool isLowerAndSunny;
                //Condition1 AND Condition2 must both be true
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine($"Result of {isLower} and(&&) {isSunny} is {isLowerAndSunny}");

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine($"Result of {isLower} or(||) {isSunny} is {isLowerAndSunny}");  //both must be false for this to be false
        }
    }
}
