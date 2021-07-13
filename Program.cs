using System;

namespace learningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           HelloWorldCSharp.HelloWorld hello = new HelloWorldCSharp.HelloWorld();
           hello.SetHello("Hello World");
           Console.WriteLine(hello.GetHello());
        }
    }
}
