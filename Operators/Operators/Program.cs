using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 2;
            var c = 3;
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a % b);
            Console.WriteLine((a + b + c)/3);
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b)); // should be simplified to a single negative
            Console.WriteLine(c > b && c < a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));
            Console.WriteLine();
           
            //What would be the output of this program? 257, 0 or 1 answer 1
            byte f = 255;
            f += 2;
            Console.WriteLine(f);

            //What would be the value of number2 after this code is executed? cant be compiled...
            //Console.WriteLine();
            //int number1 = 257;
            //byte number2 = number1; // can't put a int into a byte


            //Comments
            // two slashes for  single line comments 
            // and multi line



        }
    }
}
