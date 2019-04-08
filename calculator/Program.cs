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
            int num1;
            int num2;

            Console.WriteLine("Enter 1st number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            num2 = int.Parse(Console.ReadLine());

            Calaculator cal = new Calaculator();
            int sum cal.Addition(num1, num2);
            Console.WriteLine("Summation is : " + sum);
            Console.WriteLine("Summation is : " + cal.Addition(num1, num2));

            Console.WriteLine("Summation is : " + cal.Addition(num1, num2));
            Console.WriteLine("Division is : " + cal.Division(num1, num2));
            Console.WriteLine("Multiplication is : " + cal.Multiplication(num1, num2));
            Console.WriteLine("Substraction is : " + cal.Substraction(num1, num2));

            Console.ReadKey();

        }

         
    }
}
