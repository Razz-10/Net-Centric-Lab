using System;


namespace lab9
{
    public partial class Teacher
    {
        private string name;
        private string address;

        public Teacher(string a, string b)
        {
            this.name = a;
            this.address = b;

        }
    }
    public partial class Teacher
    {
        public void getinfo()
        {
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Address :"+address);
        }
    }

    class Demo1
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Hari Prasad Timlasina", "Banasthali");
            t1.getinfo();
            Console.WriteLine("\nQN(9C) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
