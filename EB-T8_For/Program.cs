using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            for (i = 1; i <= 10; i++)
                Console.WriteLine(i);

            Console.WriteLine("\n");

            for (int a = 0; a <= 10; a += 2)
            {
                Console.WriteLine(a);

            }

            Console.WriteLine("\n");
            for (int b = 1; b <= 10; b += 2)
            {
                Console.WriteLine(b);
            }

            Console.ReadLine();
        }
    }
}

