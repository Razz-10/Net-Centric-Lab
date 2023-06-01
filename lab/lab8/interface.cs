using System;


namespace lab8
{
     public interface Drawable
    {
        void draw();
    }

    public class Rectangler:Drawable
    {
         public void draw(){
            Console.WriteLine("Rectangle drawing..");
        }
    }
    public class Square : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
    public class Test
    {
        static void Main(string[] args)
        {
        Square S = new Square();
            S.draw();
        Rectangler R = new Rectangler();
            R.draw();

           Console.WriteLine("\nQN(8B) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
