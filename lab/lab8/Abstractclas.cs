using System;


namespace lab8
{
    public abstract class Shape //abstract class
    {
        public abstract void Draw(); // abstract method
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    public class Demo
    {
        public static void Main(string[] args)
        {
           Shape s;
            s = new Rectangle();
            s.Draw();
            s = new Circle();
            s.Draw();
            Console.WriteLine("\nQN(8A) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}