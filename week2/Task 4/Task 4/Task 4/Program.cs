using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\Users\Yernur\Desktop\C#\week2\Task 4\Task 4\Text1.txt";
            string b = @"C:\Users\Yernur\Desktop\C#\week2\Task 4\Task 4\Text2.txt";
            StreamWriter wr = new StreamWriter(a);// create object of class StreamWriter
            string text = "yernur_";
            wr.Write(text);// write the string text to the file Text1
            wr.Close();
            File.Copy(a, b);// copy the text in Text1 to Text2
            File.Delete(a);// delete  file Text1
        }
    }
}
