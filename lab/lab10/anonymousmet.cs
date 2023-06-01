using System;


namespace lab10
{
    class Test
    {
        delegate void Greet(string name);
        
        static void Main()
        {
            Greet g1 = delegate (string name)
            {
                Console.WriteLine("hello "+name);
            };

            g1("Raj");
            g1("Rikesh");
            Console.WriteLine("\nQN(10E) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
