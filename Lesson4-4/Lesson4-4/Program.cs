using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int counter = 0; counter < n; counter++)
                Console.Write($"{Fib(counter)} ,");

        }

        static int Fib(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                return Fib(n - 2) + Fib(n - 1);
            }

        }
    }
}
