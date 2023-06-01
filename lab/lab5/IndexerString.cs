using System;

namespace lab5
{
    class Student
    {
        int roll;
        string name;
        double gpa;
        public Student(int roll, string name,double gpa)
        {
            this.roll = roll;
            this.name = name;
            this.gpa = gpa;
        }
        public object this[string index]
        {
            get
            {
                if (index == "roll")
                {
                    return roll;
                }
                else if (index == "name")
                {
                    return name;
                }
                else if(index == "gpa")
                {
                    return gpa; 

                }
                return null;
            }
            set {
                if (index == "roll")
                {
                    roll = (int)value;
                }
                else if (index == "name")
                {
                    name= (string)value;
                }
                else if (index == "gpa")
                {
                    gpa = (double)value;

                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }

        }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(17, "Raj", 4.0);
            Student s2 = new Student(1, "aadarsh", 3.9);

            string name1 = (string)s1["name"];
            double gpa1 = (double)s1["gpa"];
            Console.WriteLine($"Name of first student is {name1} and Gpa is {gpa1}");
        }
    }
}
