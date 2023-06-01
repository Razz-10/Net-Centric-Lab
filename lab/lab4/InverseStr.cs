using System;
namespace lab4
{
    class InverseStr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine("Input string in reverse order:");
             int len = str.Length - 1;
              while (len >= 0) {
                Console.Write(str[len]);
                len--;
            }
            Console.WriteLine();

            str = str.Replace(" ",string.Empty); //remove space in string
            while(str.Length > 0)
            {
                Console.Write(str[0]+":");
                int count = 0;
                for(int i=0; i<str.Length; i++)
                {
                    if (str[0] == str[i]) 
                    count++;
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}
