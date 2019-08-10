using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Encapclass e1 = new Encapclass();
            e1.setAge(50);

            Console.WriteLine("Age is " + e1.getAge());

            Console.ReadKey();
        }
    }
}
