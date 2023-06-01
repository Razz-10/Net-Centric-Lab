using System;


namespace lab9
{

    struct Person
    {
        public int Id;
        public string Name;
        public int Age;
         public void display()
        {
            string info =($"\t ID:{Id} \t Name :{Name}\t Age:{Age} " );
            Console.WriteLine(info);
        }
        
    }
     class Demo
    {
        static void Main(string[] args)
        {
            Person p1;
            p1.Id= 101;
            p1.Name = "Raj tuladhar";
            p1.Age = 10;
            Person p2= new Person();
            p2.Id = 210;
            p2.Name = "RIkesh Shrestha";
            p2.Age = 50;
            Console.WriteLine("Information of first person");
            p1.display();
            Console.WriteLine("Information of Second person");
            p2.display();
            Console.WriteLine("\nQN(9A) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
