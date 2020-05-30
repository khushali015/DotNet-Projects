using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Pattern1()
        {
            Console.WriteLine("Pattern 1");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
            }
        }
        static void Pattern2()
        {
            Console.WriteLine();
            Console.WriteLine("Pattern 2");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
            }
        }
        static void Pattern3()
        {
            Console.WriteLine();
            Console.WriteLine("Pattern 3");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();
                for (int j = 5; j > i; j--)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("*");
            }
        }
        static void Pattern4()
        {
            Console.WriteLine();
            Console.WriteLine("Pattern 4");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine();
                for (int j = 4; j > i; j--)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("* ");
            }
            for (int i = 3; i >= 1; i--)
            {
                Console.WriteLine();
                for (int j = 3; j > i; j--)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write(" *");
            }
        }
        static void Main(string[] args)
        {
            Pattern1();
            Pattern2();
            Pattern3();
            Pattern4();

            /*int x = 42, y = 12, w;
            object o;
            o = x;
            w = y * (int)o;
            Console.WriteLine(w);*/

            Console.Read();
        }
    }
}
