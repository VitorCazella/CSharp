using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new MyClass();
            Console.WriteLine($"Hello World! {person.ReturnName()}");
        }
    }
}
