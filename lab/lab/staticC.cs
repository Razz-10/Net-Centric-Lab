using System;

namespace lab1
{
    class StaticC
    {
        static int count;
        public StaticC() {
            Console.WriteLine(" I'm Instance constructor");
            count++;
        }
        static StaticC()
        {
            Console.WriteLine("I'm static constructor");
            count = 0;
        }
        static void Main(string[] args) { 
            StaticC S1 = new StaticC();
            Console.WriteLine("I'm main");
            Console.WriteLine("Count ="+count);
            StaticC S2 = new StaticC();
            Console.WriteLine("Count = " + count);


        }
    }
}
