using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        class Student  // create class with the name Student
        {
            public string name;  // name of the student
            public string id;  //  ID of the student
            public int yearofstudy;  //  student study year
            public Student(string name, string id)  //  create constructor with two parameter
            {
                this.name = name;   // name is entered
                this.id = id;  //  id is entered         
            }
            public void Increment()  //  Method for incrementing the student's year of study
            {
                yearofstudy++;
            }

        }

        static void Main(string[] args)
        {
            Student s = new Student("Yernur", "18BD110941");  // create a class object Student
            s.yearofstudy = 1;  //  the default value is 1
            s.Increment();  //  after the method, the value is incremented (+1), that is, equals 2
            Console.WriteLine(s.yearofstudy);  //  Show that the Increment method works (Output: 2)

        }
    }
}
