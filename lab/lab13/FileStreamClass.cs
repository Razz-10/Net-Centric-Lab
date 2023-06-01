using System;
using System.IO;


namespace lab13
{
    class FileStreamClass
    {
        static void Main()
        {
            string fpath = @"E:\6th sem\Dot.Net\file4.txt";
            using (FileStream f1 = new FileStream(fpath, FileMode.Create))
            {

            string value = "File stream class demonstration";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(value);
            f1.Write(bytes, 0, bytes.Length);
            Console.WriteLine("Data written to the file");
            }

            using(FileStream f1 =new FileStream(fpath, FileMode.Open))
            {
                byte[] bytes = new byte[f1.Length];
                f1.Read(bytes, 0, bytes.Length);
                string data = System.Text.Encoding.UTF8.GetString(bytes);
                Console.WriteLine("Data from file :" + data);

                Console.WriteLine("\nQN(13B) Name :Raj Tuladhar    Roll.no= 15");
            }

        }
    }
}
