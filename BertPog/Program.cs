using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertPog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name}!");
            Console.WriteLine($"How was your day, {name}?");
            Console.ReadLine();
            Console.WriteLine("Don't care LOL");

            Console.ReadLine();
        }
    }
}
