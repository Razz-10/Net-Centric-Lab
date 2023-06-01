using System;

namespace lab3
{
    class Words
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[10];
                Console.WriteLine("Enter  10 words");
            for( int i=0; i < arr1.Length; i++ )
            {
                arr1[i] = Console.ReadLine();
            }
            Array.Sort(arr1);
            Console.WriteLine("Words in ascending order:");
            foreach(string s in arr1)
            {
                Console.Write("{0} ",s);
            }
        }
    }
}
