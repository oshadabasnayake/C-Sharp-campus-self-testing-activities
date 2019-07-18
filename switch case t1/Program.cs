using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//switch case************************************************************________++++++++++++++++


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enterv values");
            int num =int.Parse( Console.ReadLine()); 
          //  if (num <= 3)
           // {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;

                    case 2:
                        Console.WriteLine("two");
                        break;

                    case 3:
                        Console.WriteLine("three");
                        break;

                    default:
                        Console.WriteLine("default value");
                        break;
                }
       /*
       }
            else
            {
                Console.WriteLine("your swith value in correct");
            }   */
            Console.ReadLine();
        }
    }
}
