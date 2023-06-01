using System;

namespace lab10
{
    class ActionDelegate
    {
        static void Main(string[] args)
        {
            Action<int, int> multiply = Multiply;
            multiply(2, 5);
        }
        static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"The result of {a}*{b}= {result}");
            Console.WriteLine("\nQN(10D) Name :Raj Tuladhar    Roll.no= 15");

        }
    }
}
