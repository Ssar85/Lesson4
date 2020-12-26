using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите целые числа через пробел");
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            int sum = 0;
            for (int i =0; i< b.Length; i++)
            {
                sum += Convert.ToInt32( b[i]);
            }
            Console.WriteLine($"Сумма вчех числе равна {sum}");
        }
    }
}
