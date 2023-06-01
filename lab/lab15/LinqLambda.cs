using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    class LinqLambda
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 2,5,4,9,12,8,3,10,6};
            var lessThan5=  num.Where(x => x <5);
            Console.WriteLine("Numbers less than 5 are");
            foreach(int x in lessThan5)
            {

                Console.Write(x+" ");
            }
            var sum = num.Where(x => x < 5).Sum();
            Console.WriteLine("\nSum of all numbers less than 5 is " + sum);

            Console.WriteLine("\nQN(15B) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
