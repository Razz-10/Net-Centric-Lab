using System;
using System.Collections.Generic;


namespace lab12
{
    class GenMth<T>
    {
        public T[] _data=new T[10];
        public void AddUpdate(int index, T value)
        {
            if(index>=0 && index<10) {
                _data[index] = value;}
        }
        public T Getdata(int index)
        {
            if(index>=0 && index<10) { 
                return _data[index];
            }
            else
                return default(T);
        }
    }
    class GenericMethod
    {
        static void Main(string[] args) { 
        GenMth <string> P =new GenMth<string>();
            P.AddUpdate(1, "Koshhi");
            P.AddUpdate(2, "Mechhi");
            P.AddUpdate(3, "Bagmati");

            for(int i = 0; i < 5; i++)
            {

            Console.WriteLine(P.Getdata(i));
            }

            Console.WriteLine("\nQN(12C) Name :Raj Tuladhar    Roll.no= 15");
        }

    }
}
