using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "[*]";  //  one copy star triangle 
            int a = int.Parse(Console.ReadLine());  //  enter number
            for (int i = 1; i <= a; i++)  //      use loop in loop
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(s);  // display the startriangle incrementing with each iteration
                }
                Console.WriteLine();   // move to the next line
            }
            Console.ReadLine();  //  don't close immeadiately
        }
    }
}
