using System;
using System.IO;
using System.Text;


namespace lab13
{
     class BinReaderWriter
    {
        static void Main(string[] args)
        {
            string fname= @"E:\6th sem\Dot.Net\file1.txt";
            int val1 = 15;
            int val2 = 16;
            using(BinaryWriter bw = new BinaryWriter(File.Open(fname,FileMode.Create))) { 
                bw.Write(val1); 
                bw.Write(val2);

            }
            using (BinaryReader br =new BinaryReader(File.Open(fname,FileMode.Open)))
            {
                int a = br.ReadInt32();
                int b = br.ReadInt32();
                Console.WriteLine($"First value is {a} and Second value is {b}");

                Console.WriteLine("\nQN(13A) Name :Raj Tuladhar    Roll.no= 15");
            }

        }
    }
}
