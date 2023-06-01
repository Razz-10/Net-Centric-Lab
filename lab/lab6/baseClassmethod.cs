using System;

namespace lab6
{
    public class Bikeb
    {
        public virtual void displayCC()
        {
            Console.WriteLine("The cc of bike are:500cc 400cc 300cc 150cc 100cc");
        }
    }
    public class Splender:Bikeb
    {
        public override void displayCC()
        {
            base.displayCC();
            Console.WriteLine("The cc of splender(derived class) is 100CC");
        }
    }

    class Demod
    {
        static void Main() {
        Splender S100 = new Splender();
        S100.displayCC();
            Console.WriteLine("\nRaj Tuladhar    Roll.no = 17 (Qn6B)");
        }
    }
}
