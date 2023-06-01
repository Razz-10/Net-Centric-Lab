using System;
using System.Linq;
using System.Text;

namespace lab15
{
    class LinQ
    {
        static void Main(string[] args)
        {
            int[] marks  = new int[] { 20,19,2,30,40,52,80,10,88,90,40};
             var result1 = from mar in marks where mar>40 select mar ;//linq expression
            Console.WriteLine("Marks greater than 40 are");
            foreach (int i in result1)
            { Console.Write(i+" "); }
        
            var result2 = from mar in marks where mar<70 orderby mar ascending select mar;
            Console.WriteLine("\nscores less than 70 in ascending order are:");
            foreach(int i in result2)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("\nQN(14) Name :Raj Tuladhar    Roll.no= 15");
        }

    }
}
