using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CineAdviser: Welcome!!!");
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            String text = "Hello, " + name;
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
