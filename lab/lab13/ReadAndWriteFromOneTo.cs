using System;
using System.IO;
using System.Text;


namespace lab13
{
   class ReadAndWriteFromOneTo
    {
        static void Main(string[] args)
        {
            string fsource = @"E:\6th sem\Dot.Net\source.txt";
            string fdestination = @"E:\6th sem\Dot.Net\desti.txt";
            if(File.Exists(fsource) )
            {
                string Stext = File.ReadAllText(fsource);
                Console.WriteLine("The content that is reading from source file is :"+Stext);
                File.WriteAllText(fdestination, Stext);
                Console.WriteLine("The content is written sucessfull.Check in desti.txt file");
                Console.WriteLine("\nQN(13E) Name :Raj Tuladhar    Roll.no= 15");


            }
            else
            {
                Console.WriteLine("FIle not found");
            }

        }
    }
}
