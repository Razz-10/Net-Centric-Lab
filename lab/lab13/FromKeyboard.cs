using System;
using System.IO;
using System.Text;

namespace lab13
{
    class FromKeyboard
    {
        static void Main(string[] args)
        {

        string ftextFromKey = @"E:\6th sem\Dot.Net\textFromkeyboard";
            if (!File.Exists(ftextFromKey)) { 
              Console.WriteLine("Enter the text you want to write:");
        string content=Console.ReadLine();
            File.WriteAllText(ftextFromKey,content);
            Console.WriteLine("Written Sucessfully");

            Console.WriteLine("\nQN(13F) Name :Raj Tuladhar    Roll.no= 15");
            }

        }
    }
}
