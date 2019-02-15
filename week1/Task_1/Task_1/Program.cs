using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static bool Prime(int n)// bool function that checks is number prime
        {
            bool b = true;
            if (n <= 1)
            {
                b = false;
                return b;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)// if there is a number that the checked number is divided into, the function returns false, that is, the number is not prime. 
                {
                    b = false;
                    return b;
                }
            }
            return b;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// Enter the number of elements in the array
            int[] ar = new int[n];
            string s = Console.ReadLine();// Enter the array elements through the string
            string[] ss = s.Split(' ');// divide each number into seperate elements of the array 
            for (int i = 0; i < ss.Length; i++)// string string to the int
            {
                ar[i] = int.Parse(ss[i]);
            }
            List<int> b = new List<int>();// create integer array
            foreach (int q in ar)// go over the array
            {
                if (Prime(q))// we'll check primes and enter them into another array
                {
                    b.Add(q);
                }
            }
            Console.WriteLine(b.ToArray().Length);// print the number of prime numbers
            for (int i = 0; i < b.ToArray().Length; i++)// print all prime nubmeers
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadKey();//don't close immediately
        }
    }
}
