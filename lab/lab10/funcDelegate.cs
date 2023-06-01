using System;


namespace lab10
{
    class FuncDelegate
    {
        static void Main(string[] args)
        {
            Func<string, string, int> concatCount = ConcatCount;
            int result = concatCount("Raj", "Tuladhar");
            Console.WriteLine("The length of concated string is "+ result);
            Console.WriteLine("\nQN(10C) Name :Raj Tuladhar    Roll.no= 15");

        }
        static int ConcatCount(string s1, string s2) {
        string s3=s1+s2;
            return s3.Length;

        }
    }
}
