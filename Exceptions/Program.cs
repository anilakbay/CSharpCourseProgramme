using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Buse", "Simge", "Cansu" };
                students[3] = "Ali";
            }
            catch (Exception exception)
            {
                Console.WriteLine("EXCEPTİONNNNN!");
            }

            Console.ReadLine();
            
            
        }
    }
}
