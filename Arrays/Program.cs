using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Anıl", "Cansu", "Buse" };  students[0] = "Anıl";
                                                                            students[1] = "Cansu";
                                                                            students[2] = "Buse";
            string[] students2 = {"Anıl", "Cansu", "Buse"};
            students2[3] = "Elif";
            foreach(var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
