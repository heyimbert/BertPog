using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BertPog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name}!");
            Thread.Sleep(1000);
            Console.WriteLine($"How was your day, {name}?");
            Console.ReadLine();
            Console.WriteLine("Don't care LOL");

            Console.ReadLine();
        }
    }
}
