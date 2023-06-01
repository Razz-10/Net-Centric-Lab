using System;


namespace lab4
{
    class SubstringEnd
    {
        static void Main(string[] args)
        {
            string str = "Im csit student";
            string start = "Im cs";
            string end = "ent";
            Console.WriteLine(str) ;
            bool s = str.StartsWith(start);
            bool e = str.EndsWith(end);

            if (s && e) {
                Console.WriteLine($"String start with {start}.");
                Console.WriteLine($"String end with {end}.");

            }
            else if (s) {
                
                    Console.WriteLine($"The string starts with {start} but does not end with {end}.");
                }
             else if( e)
                {
                Console.WriteLine($"The string  does not starts with {start} but end with {end}.");

            }
            else
            {
                Console.WriteLine($"The string  does not starts with {start} and end with {end}.");
            }
        }
    }
}
