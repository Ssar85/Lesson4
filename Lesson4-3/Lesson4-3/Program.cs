using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_3
{
    class Program
    {
        enum Season
        {
            Весна,
            Лето,
            Осень,
            Зима
        }
        static void Main(string[] args)
        {
             Console.WriteLine((Season)PrintSeason());
        }

        static int ReadSeason()
        {
           
            Console.WriteLine("Введите номер месяца");
            int s1 = Convert.ToInt32(Console.ReadLine());
            if (s1>0 & s1<13)
            {
                return s1;
            }
            else
            {
                PrintError();
                return 0;
            }
            
        }
        static void PrintError()
        {
           Console.WriteLine("Введите целое число от 1 до 12");
           ReadSeason();
        }
        static int PrintSeason()
        {

            int s = Convert.ToInt32(ReadSeason());
            switch (s)
            {
                case 3:
                case 4:
                case 5:
                    s = 0;
                    break;
                case 6:
                case 7:
                case 8:
                    s = 1;
                    break;
                case 9:
                case 10:
                case 11:
                    s = 2;
                    break;
                case 1:
                case 2:
                case 12:
                    s = 3;
                    break;
            }
            return s;
        }
    }
}
