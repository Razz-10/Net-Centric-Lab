using System;

namespace lab1
{
    class PrivateC
    {
        private PrivateC() { }
        public static int count;
        public static int counter()
        { 
            return ++count; 
        }
    }

    class Testcounter {
        static void Main(string[] args)
        {
         //   PrivateC P1=new PrivateC(); this will cause error casue it it not accesbile due to its acess specificer is private
            PrivateC.count = 0;
            PrivateC.counter();
            Console.WriteLine("the value of count ="+ PrivateC.count);

        }
    
    }
}
