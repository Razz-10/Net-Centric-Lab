using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
[Obsolete("This class is deprecated. Use the NewClass instead.")]
public class DeprecatedClass
{
    public void DeprecatedMethod()
    {
        Console.WriteLine("This method is deprecated.");
    }
}

public class NewClass
{

    [Serializable]
    public class SerializableClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

class BuiltinAtt
{
    static void Main(string[] args)
    {
        DeprecatedClass d1 = new DeprecatedClass();
        d1.DeprecatedMethod();

        NewClass.SerializableClass sO = new NewClass.SerializableClass();
        sO.Name = "Raj Tuladhar";
        sO.Age = 17;

        Console.WriteLine("Serializable Object: Name={0}, Age={1}", sO.Name, sO.Age);
        Console.WriteLine("\nQN(17A) Name :Raj Tuladhar    Roll.no= 15");
    }
}
}

