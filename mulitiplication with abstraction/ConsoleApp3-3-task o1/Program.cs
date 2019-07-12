using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program : absClass
    {
        static void Main(string[] args)
        {
            Program pm = new Program();
            int sum = pm.AddTwoNumbers(10, 20);
            int mul = pm.MultiplyNumbers(10, 20);
            Console.WriteLine("summation : " + sum);
            Console.WriteLine("Multiplication :  " + mul);

            Console.ReadLine();
        }

        public override int MultiplyNumbers(int x , int y)
        {

            return x * y;
        }
       
    }
}
