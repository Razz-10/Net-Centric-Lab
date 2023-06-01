using System;

namespace lab1
{
    class DefaultC
    {
        string name;
        int roll;

        public DefaultC()
        {
            Console.WriteLine("Default Constructor");
            roll = 15;
            name = "Raj Tuladhar";
        }

        static void Main(string[] args)
        {
            DefaultC c = new DefaultC();
            Console.WriteLine("Name:" + c.name);
            Console.WriteLine("roll no:" + c.roll);
        }
    }

}
