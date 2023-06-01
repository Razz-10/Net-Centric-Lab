using System;

namespace lab6
{
    class BaseClass
    {
        int num;
        public BaseClass()
        {
            Console.WriteLine(" this is Base Class()");
        }
        public BaseClass(int i)
        {
            num= i;
            Console.WriteLine("this is BaseClass(int i)");
        }
        public int get()
        {

            return num;
        }

    }

    class DerivedClass : BaseClass
    {
        public DerivedClass():base() { }
        public DerivedClass(int i):base(i) { }
        static void Main(string[] args)
        {
            DerivedClass d1=new DerivedClass();
            DerivedClass d2=new DerivedClass(10);
            Console.WriteLine("Number = "+d2.get());
            Console.WriteLine("\nRaj Tuladhar    Roll.no = 17 (Qn6C)");

        }
    }
}
