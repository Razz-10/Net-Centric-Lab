using System;
using System.Collections;

namespace lab11
{
    class nongenColl
    {
        //ARRAY list class
        static void Main(string[] args)
        {

        ArrayList list = new ArrayList();
            Console.WriteLine("Lets Add some number:");
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(1);
            list.Add(2);
            Console.WriteLine("Capacity = {0}", list.Capacity);
            Console.WriteLine("count = {0}",list.Count);
            Console.Write("Values in Arraylist are:");
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.Write("value in reverse order :");
            list.Reverse();
            foreach (int i in list) {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nQN(11A) Name :Raj Tuladhar    Roll.no= 15");

        }


    }
}
