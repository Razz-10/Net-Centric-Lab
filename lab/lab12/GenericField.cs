using System;
using System.Collections.Generic;


namespace lab12
{
    class  Data <T>
    {
        public T data;
    }
    class GenericField
    {
        static void Main(string[] args)
        {
            Data <int> age = new Data <int> ();
            age.data = 12;
           Data <string> name = new Data <string> ();
            name.data = "Hari Prasad Timalsina";

            Console.WriteLine("Name :"+name.data);
            Console.WriteLine("Age : "+age.data);

            Console.WriteLine("\nQN(12B) Name :Raj Tuladhar    Roll.no= 15");

        }
    }
}
 