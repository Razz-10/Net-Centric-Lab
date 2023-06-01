using System;

namespace lab1
{
    class CopyCon
    {
        int num1;
        int num2;
        public CopyCon(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public CopyCon(CopyCon c1)
        {
            num1 = c1.num1;
            num2 = c1.num2;
        }
         public void Display()
        {
            Console.WriteLine("num1 is {0} and num2 is {1}", num1, num2);
        }

        static void Main(string[] args)
        {
            CopyCon cd1 = new CopyCon(1, 2);
            CopyCon cd2 = new CopyCon(cd1);
            Console.WriteLine("Detail of cd1 object:");
            cd1.Display();
            Console.WriteLine("Detail of cd2 object:");
            cd2.Display();
        }
    }
}
