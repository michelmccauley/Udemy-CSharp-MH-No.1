using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //works
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //wont work
            //int i = 1;
            //byte b = i;
            //Console.WriteLine(i);
            //Fix
                int i = 1;
                byte b = (byte)i;
                Console.WriteLine(b);
            // this will work but cause an error conversion... int max is 255 and is set to 1000 in this example
                int z = 1000;
                byte w = (byte)z;
                Console.WriteLine(w);
            Console.WriteLine();
            // Strings
            
            
            try
            {

                string str = "true";
                bool q = Convert.ToBoolean(str);
                Console.WriteLine(q);

                var  number = "255"; //Max number 255... try 2551 and get an exception error.
                byte c = Convert.ToByte(number); //Example... System.OverflowException: 'Value was either too large or too small for an unsigned byte.'
                Console.WriteLine(c);


               

            }
            catch (Exception)
            {
                Console.WriteLine("Error --> The number could not be converted to a byte");
                
               }
            








        }
    }
}
