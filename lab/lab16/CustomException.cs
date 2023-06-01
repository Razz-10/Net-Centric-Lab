using System;
using System.Text;


namespace lab16
{
    public class TempIsZeroException : Exception {
        public TempIsZeroException(string message):base(message) {
        }
    }
    public class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature :{0}",temperature);
            }
        }

    }
    class CustomException
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException ex) { 
            Console.WriteLine(ex.Message);}
            Console.WriteLine("\nQN(16C) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
