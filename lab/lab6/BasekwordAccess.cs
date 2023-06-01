using System;
using System.Drawing;

namespace lab6
{
    public class Bike
    {
        public string color = "white";
    }
    public class Hero :Bike
    {
        string color = "Black And White";
        public void display()
        {
            Console.WriteLine($"Color of base class is {base.color}");
            Console.WriteLine($"Color of  derived class is {color}");
        }
    }


    public class Demo
    {
        static void Main(string[] args)
        {
            Hero B1 = new Hero();
            B1 .display();

            Console.WriteLine("\nRaj Tuladhar    Roll.no = 17");
        }
    }
}
