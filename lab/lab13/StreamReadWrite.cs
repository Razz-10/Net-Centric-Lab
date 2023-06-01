using System;
using System.IO;
using System.Text;


namespace lab13
{
    class StreamReadWrite
    {
        static void Main(string[] args)
        {
            string fpath = @"E:\6th sem\Dot.Net\file3.txt";
            FileStream f1 = new FileStream(fpath, FileMode.OpenOrCreate);
            StreamWriter sr= new StreamWriter(f1);
            sr.WriteLine("FIle handilng using stream reader and writer");
            sr.Close();
            f1.Close();
            FileStream f2 = new FileStream (fpath, FileMode.Open);
            StreamReader sr2= new StreamReader(f2);
            string text = sr2.ReadLine();
            Console.WriteLine("The content of file is :");
            Console.WriteLine(text);
            sr2.Close();
            f2.Close();
            Console.WriteLine("\nQN(13D) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
