using System;

namespace CSharpSkeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class HelloWorld {
        public string Greet(string name){
            return $"Hello {name}!";
        }
    }
}
