using System;

namespace lab5
{
    class Indexer
    {
        private string[] name = new string[3];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set { name[i] = value; }

        }
    }
      class Demo
        {
            static void Main(string[] args)
            {

                Indexer I1 = new Indexer();

                I1[0] = "Raj Tuladhr";
                I1[1] = "Rikesh Shrestha";
                I1[2] = "Aadarsh Bhattarai";

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(I1[i]);
                }
            }
        }
}



