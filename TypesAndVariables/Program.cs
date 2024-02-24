using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            bool condition = false;
            char character = 'A';
            int number1 = 567894328;
            long number2 = 567894328;
            short number3 = -32768;
            byte number4 = 255;
            double number5 = 9.6;
            Console.WriteLine(number1);
            Console.WriteLine(number3);
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("character is: {0}",character);
            Console.ReadLine();
        }
    }
}
