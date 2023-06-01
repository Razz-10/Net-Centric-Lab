using System;


namespace lab7
{
     public class Animal
    {
        public virtual void Makesound()
        {
            Console.WriteLine("Animal makes different sound");
        }
    }

    public class Dog:Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat: Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Animal A = new Animal();
            A.Makesound();
            Dog D1 = new Dog();
            Cat C1 = new Cat();
            A = D1;
            A.Makesound();
            A = C1;
            A.Makesound();
            Console.WriteLine("\nQN(7B) Name :Raj Tuladhar    Roll.no= 15");
        }
    }

}
