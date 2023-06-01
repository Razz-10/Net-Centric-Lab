using System;


namespace lab4
{
    class CountWordstr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Input string:");
            string str = Console.ReadLine();
            // int word = 1;
            int l = 0;
            Console.WriteLine("Total number of character is :"+ str.Length);
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int wCount = words.Length;
             Console.WriteLine("Total numbers of word is " + wCount);
           
            /* while (l < str.Length) {
                 if (str[l] == ' '|| str[l]=='\n'|| str[l]=='\t') {
                 word++;
                 }
                 l++;
             }

         */

            for(int i = 0; i< wCount; i++)
            {
                int count = 1;
                if (words[i] !=null) {
                for(int j=i+1; j<wCount; j++)
                    {
                        if (words[i] == words[j]) {
                            count++;
                            words[j] = null;
                        }
                    }
                    Console.WriteLine($"{words[i]}:{count}");
                }
            }
        }
    }
}
