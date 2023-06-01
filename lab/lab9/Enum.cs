using System;


namespace lab9
{
    public enum Student
    {
        Raj,Aadarsh,Rikesh,Bibek
    }
    public enum Course { Csit=201,Bca,Bia,Mbbs=300,BBS}
    class Enum
    {
        static void Main(string[] args)
        {
            int a = (int)Student.Raj;
            int b= (int)Student.Bibek;
            Console.WriteLine("Integral value of {0} = {1}",Student.Raj,a);
            Console.WriteLine("Integral value of {0} = {1}", Student.Bibek, b);
            Console.WriteLine("Integral value of Courses:");

            Console.WriteLine(Course.Csit+" =  "+(int)Course.Csit);
            Console.WriteLine(Course.Bca + " =  " + (int)Course.Bca);
            Console.WriteLine(Course.Bia + " =  " + (int)Course.Bia);
            Console.WriteLine(Course.Mbbs + " =  " + (int)Course.Mbbs);
            Console.WriteLine(Course.BBS + " =  " + (int)Course.BBS);
            Console.WriteLine("\nQN(9B) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
