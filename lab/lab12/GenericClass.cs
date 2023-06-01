using System;
using System.Collections.Generic;


namespace lab12
{
    class Datastore<T>
    {
        public  T Data{ get; set; }
    }
    class Keyvalue<Tkey, Tval>
    {
        public Tkey Key { get; set; }
        public Tval Value { get; set; }
    }
        
     class GenericClass
    {
        static void Main(string[] args)
        {
            Datastore<string> name = new Datastore<string>();//string Type
            name.Data = "Raj Tuladhar";
            Console.WriteLine("Name: "+name.Data);
            Datastore<int> id = new Datastore<int>();
            id.Data = 1;
            Console.WriteLine("Rol no: "+id.Data);
            Keyvalue <int,string> info = new Keyvalue<int,string>();
            info.Key = 1;
            info.Value = "Raj Tuladhar";
            Console.WriteLine(info.Key+" "+info.Value);

            Console.WriteLine("\nQN(12A) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
