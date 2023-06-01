using System;

namespace lab7
{
     public class Parent
    {
        public virtual void marriage()
        {
            Console.WriteLine("Arrange Marriage");
        }
        public void haveson()
        {
            Console.WriteLine("parent must have child");
        }
    }
     public class Son : Parent
    {
        public override void marriage()
        {
            Console.WriteLine("Love Marriage");
        }
        public new void haveson()
        {
            Console.WriteLine("son may not have child.");
        }
    }

    class Test
    {
          static void Main(string[] args) {
            Son s1 = new Son();
            s1.marriage();
            s1. haveson();
            Console.WriteLine("\nQN(7A) Name :Raj Tuladhar    Roll.no= 17");
        }
    }
}
