using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Appone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();
        }
      
        
    }
}
