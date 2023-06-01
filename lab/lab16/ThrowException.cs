using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    class ThrowException
    {
        static void Agecheck(int age)
        {
            if (age > 0)
            {
                Console.WriteLine("Age  is :"+age);
            }
            else
            {
                throw new ArithmeticException("Negative age is not possible");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Agecheck(12);
                Agecheck(-2);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Exception Caught:"+e.Message);
            }
            Console.WriteLine("\nQN(16B) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
