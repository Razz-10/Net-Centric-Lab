using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    class TrycatchExpection
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int sum = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally {
                Console.WriteLine("Finally block is executed");

            }
            Console.WriteLine("Rest of the code");
            Console.WriteLine("\nQN(16A) Name :Raj Tuladhar    Roll.no= 15");
        }

    }
}
