using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void CompleteArray(int[] ar1, int[] ar2)  // create static method
        {
            for (int i = 0; i < ar1.Length; i++)
            {
                ar2[2 * i] = ar1[i];     // every two elements of the second array take on values
                ar2[2 * i + 1] = ar1[i];   // each element of the first array
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //  number of elements in the first array
            string s = Console.ReadLine(); //  we enter the first array in the form of one line
            string[] ss = s.Split(' '); // we divide each array number as an array of strings
            int[] arr2 = new int[2 * n];  //  we declare the second array with two more elements
            int[] arr1 = new int[n];  // declare the first array
            for (int i = 0; i < ss.Length; i++)  // all elements of the array of strings are converted into elements of an array of integers 
            {
                arr1[i] = int.Parse(ss[i]);
            }
            CompleteArray(arr1, arr2);   // method to fill the second array on demand
            foreach (int a in arr2)   //  Output the elements of the final array
            {
                Console.Write(a + " ");
            }
            Console.ReadLine();  // do not close immeadiately
        }
    }
}