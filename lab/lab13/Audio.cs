using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {


        static void Main()
        {
            string sourceFile = @"E:\\6th sem\\Dot.Net\clamdown\";
            string destinationFile = @"E:\\6th sem\\Dot.Net\copyclam.wav";

            // Read audio file and create a copy
            ReadAndWriteAudioFile(sourceFile, destinationFile);

            Console.WriteLine("Audio file copied successfully.");
        }

        static void ReadAndWriteAudioFile(string sourceFile, string destinationFile)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(sourceFile, FileMode.Open)))
            using (BinaryWriter writer = new BinaryWriter(File.Open(destinationFile, FileMode.Create)))
            {
                byte[] buffer = new byte[1024]; // Buffer to read chunks of data

                // Read data from the source file and write to the destination file
                int bytesRead;
                while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    writer.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}