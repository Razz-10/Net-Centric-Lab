using System;

namespace lab1
{
    class Property
    {
        double radius= 1.5;
        public double Radius { 
            get 
            { 
                return radius; 
            }
            set 
            {
                radius = value; 
            } 
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Property C1 = new Property();
            double oldradius = C1.Radius;
            Console.WriteLine("Old radius = "+oldradius);
            C1.Radius = 10;
            double newradius = C1.Radius;
            Console.WriteLine("New radius = "+newradius);
        }
    }
}
