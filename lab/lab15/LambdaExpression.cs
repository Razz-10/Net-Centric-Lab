using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    public delegate int add2(int num);
    public delegate void HelloDele(string name);
    class LambdaExpression
    {
        static void Main(string[] args)
        {
            LambdaExpression L1 = new LambdaExpression();
            //statement lamda
            HelloDele H1 = (name) =>
            {
                Console.WriteLine("Hey!!" + name  + " How are you??");
            };
            //expression labda 
            add2 A1 = (num) => num + 2;
            H1("Raj Tuladhar");
            int result = A1(8);
            Console.WriteLine("8+2=" + result);

            Console.WriteLine("\nQN(15A) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
