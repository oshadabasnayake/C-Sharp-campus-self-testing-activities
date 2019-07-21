using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 20)
            {
                if (num == 5)
                    break;

                Console.WriteLine(num);
                num++;
            }
        }
    }
}