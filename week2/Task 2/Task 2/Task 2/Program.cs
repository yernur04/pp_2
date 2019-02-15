using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
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
            StreamReader k = new StreamReader(@"C:\Users\Yernur\Desktop\C#\week2\Task 2\Task 2\Text.txt");// create object of class StreamReader
            string array = k.ReadToEnd(); // enter the numbers to the array 
            string[] array1 = array.Split(' ');// divide numbers
            StreamWriter writer = new StreamWriter(@"C:\Users\Yernur\Desktop\C#\week2\Task 2\Task 2\Output.txt");// create object of class StreamWriter
            for (int i = 0; i < array1.Length; i++)
            {
                int tr = int.Parse(array1[i]);
                if (Prime(tr))// check whether the number is prime
                {
                    writer.Write(tr);
                    writer.Write(" ");
                }
            }
            writer.Close();// close the text
        }
    }
}
