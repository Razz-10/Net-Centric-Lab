using System;


namespace lab10
{
    public delegate void sumDelegate(int x, int y);
    public delegate string introDelegate(string str);


    public class DemoDelegate
    {
        public void sum(int a,int b)
        {
            Console.WriteLine("\tSum ="+ (a+b));
        }
        public static string Intro(string name)
        {
            return "Hello,My name is " + name;
        }
        static void Main(string[] args)
        {
            DemoDelegate d1 = new DemoDelegate();
            sumDelegate sd = new sumDelegate(d1.sum);   //settig target one way
            sd.Invoke(9, 10);//invoking way
            introDelegate id = Intro;//target setting another way
            string s = id("Raj tuladhar");//another invoking way
            Console.WriteLine(s);
            Console.WriteLine("\nQN(10A) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
