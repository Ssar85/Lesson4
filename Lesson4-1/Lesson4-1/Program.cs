using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FIO1;
            String FIO2;
            String FIO3;
            FIO1 = GetFullName();
            FIO2 = GetFullName();
            FIO3 = GetFullName();
            Console.WriteLine($"ФИО 1:{FIO1} ; ФИО 2:{FIO2} ; ФИО 3:{FIO3}");

        }

        static string GetFullName()
        {
            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите Имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите Отчество:");
            string patronymic = Console.ReadLine();
            string FIO = ($"{lastName} {firstName} {patronymic}");
            return (FIO);
        }        
    }
}
