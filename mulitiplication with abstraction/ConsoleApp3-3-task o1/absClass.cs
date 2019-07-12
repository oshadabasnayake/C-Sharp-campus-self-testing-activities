using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   abstract class absClass
    {
        public abstract int MultiplyNumbers(int x , int y);

        public int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
        public absClass()
        {
            Console.WriteLine("hello world");
        }
    }   
}
