using System;

namespace lab1
{
   class ParaCons
    {
        string name;
        long num;
        public ParaCons(string na, long n)
        {
            name = na;
            num = n;
            Console.WriteLine("My name is "+name);
            Console.WriteLine("my mobile num is " + num);
        }

        static void Main(string[] args)
        {
            ParaCons p1 = new ParaCons("Raj",9818609105); 
            ParaCons p2 = new ParaCons("Rikesh",98222556);
                }
    }
}
