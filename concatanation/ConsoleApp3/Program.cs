using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("hello " + username + " welcome & you are " + age + " old.");

            Console.ReadKey();
        }
    }
}
