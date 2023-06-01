using System;
using System.Collections.Generic;


namespace lab11
{
    class Genericcol
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Names.Add("Raj");
            Names.Add("Aadarsh");
            Names.Add("Rikesh");
            Names.Add("Bibek");


            Console.WriteLine("Names in list are :");
            foreach (string name in Names) {
                Console.Write(name+" ");
            }
            Console.WriteLine();
            Console.WriteLine("\nQN(11B) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
