using System;
using System.Text;


namespace lab17
{
    // Define a custom attribute
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomAttribute : Attribute
    {
        public string Description { get; }

        public CustomAttribute(string description)
        {
            Description = description;
        }
    }

    public class MyClass
    {
        [CustomAttribute("This is a custom attribute")]
        public void MyMethod()
        {
            Console.WriteLine("Executing MyMethod");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyClass
            MyClass myObject = new MyClass();

            // Retrieve the method information using reflection
            var methodInfo = typeof(MyClass).GetMethod("MyMethod");

            // Retrieve the custom attribute information
            var attribute = (CustomAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(CustomAttribute));

            // Use the custom attribute
            if (attribute != null)
            {
                Console.WriteLine("Attribute Description: " + attribute.Description);
            }

            // Call the method
            myObject.MyMethod();
            Console.WriteLine("\nQN(17B) Name :Raj Tuladhar    Roll.no= 15");
        }
    }
}
