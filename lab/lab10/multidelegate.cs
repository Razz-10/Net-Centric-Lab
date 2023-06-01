using System;

namespace lab10
{
    public delegate void delegateReact(double length, double breadth);
    class Reactangle
    {
        public void GetArea(double length,double breadth) {
            string  Area = $"Area of rectangle= {length * breadth}";
            Console.WriteLine(Area);
        }
        public void GetPerimetre(double length,double breadth)
        {
            string Peri = $"Perimetre of rectangle ={2 * (length + breadth)}";
            Console.WriteLine(Peri);
        }
        static void Main(string[] args)
        {
            Reactangle r1 = new Reactangle();
            delegateReact dr1 = r1.GetArea;
            delegateReact dr2 = r1.GetPerimetre;
            delegateReact dr3 = dr1 + dr2;
            dr3.Invoke(10, 10);
            dr3 -= dr1;//removing dr1
            Console.WriteLine("After removing dr1 delegate object");
            dr3.Invoke(10, 10);
            Console.WriteLine("\nQN(10B) Name :Raj Tuladhar    Roll.no= 15");

        }
    }

}
