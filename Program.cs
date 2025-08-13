using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entry = "";
            int n = 0;

            Console.WriteLine("Multiplication Table Program");
            Console.Write("Type your number:");
            //DATA ENTRY
            entry = Console.ReadLine();
            n = Convert.ToInt32(entry);
            //MULTTABLE
            Console.WriteLine(n + " x 1 = " + (n * 1));
            Console.WriteLine(n + " x 2 = " + (n * 2));
            Console.WriteLine(n + " x 3 = " + (n * 3));
            Console.WriteLine(n + " x 4 = " + (n * 4));
            Console.WriteLine(n + " x 5 = " + (n * 5));
            Console.WriteLine(n + " x 6 = " + (n * 6));
            Console.WriteLine(n + " x 7 = " + (n * 7));
            Console.WriteLine(n + " x 8 = " + (n * 8));
            Console.WriteLine(n + " x 9 = " + (n * 9));
            Console.WriteLine(n + " x 10 = " + (n * 10));
            Console.ReadKey();

        }
    }
}
