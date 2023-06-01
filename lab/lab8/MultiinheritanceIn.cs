using System;

namespace lab8
{

    interface Draw
    {
        void draw();
    }
    interface Print
    {
        void print();
    }
   public  class MultiinheritanceIn:Draw, Print
    {
        public void draw()
        {
            Console.WriteLine("Something is Drawing");
        }
        public void print()
        {
            Console.WriteLine("Somthing is printing");
        }
        public static void Main(String[] args)
        {
            MultiinheritanceIn m1 = new MultiinheritanceIn();
            m1.draw();
            m1.print();
            Console.WriteLine("\nQN(8C) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
    
 }
