using System;
using System.IO;
using System.Text;

namespace lab13
{
    class TextReaderWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"E:\6th sem\Dot.Net\file2.txt";
            if(File.Exists(fpath))//checking if exists
            {
                File.Delete(fpath);
            }
            using(TextWriter tw = File.CreateText(fpath))
            {
                tw.WriteLine("Hello C# file handling");
                tw.WriteLine("Text reader and text writer demostration");
            }
            using(TextReader tr = File.OpenText(fpath))
            {
                Console.WriteLine(tr.ReadToEnd());
                Console.WriteLine(tr.ReadLine());
                Console.WriteLine("\nQN(13C) Name :Raj Tuladhar    Roll.no= 15");
            }
        }
    }
}
