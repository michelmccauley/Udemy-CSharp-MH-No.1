using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAnd_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 3
            Console.WriteLine("Lesson 3");
            const float Pi = 3.1416f;
            Console.WriteLine(Pi);
            Console.WriteLine();

            //Lesson 2
            Console.WriteLine("Lesson 2");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} is smaller than {1}", float.MinValue, float.MaxValue);
            Console.WriteLine();
            
            
            //Lesson 1
            Console.WriteLine("Lesson 1");
            byte number = 5;
            int count = 10;
            float totalPrice = 20.69f;
            char character = 'a';
            string firstName = "Michel";
            bool isWorking = true;


            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

        }
    }
}
