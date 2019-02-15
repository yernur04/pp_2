using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static public bool isPalindrome(string a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Yernur\Desktop\C#\week2\Task 1\Task 1\Text.txt");// read the text
            if (isPalindrome(text))// checking is text palindrome
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
