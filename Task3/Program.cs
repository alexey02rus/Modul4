using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые положительные числа A, B и С");
            Console.Write("А = ");
            string value1 = Console.ReadLine();
            bool integer1 = (Int32.TryParse(value1, out int a) && a > 0) ? true : false;
            Console.Write("B = ");
            string value2 = Console.ReadLine();
            bool integer2 = (Int32.TryParse(value2, out int b) && b > 0) ? true : false; ;
            Console.Write("C = ");
            string value3 = Console.ReadLine();
            bool integer3 = (Int32.TryParse(value3, out int c) && c > 0) ? true : false; ;
            Console.WriteLine();
            if (integer1 && integer2 && integer3)
            {
                int lengthA = 0;
                int lengthB = 0;
                int n = 0;
                while (a - lengthA >= c)
                {
                    while (b - lengthB >= c)
                    {
                        lengthB += c;
                        n++;
                    }
                    lengthB = 0;
                    lengthA += c;
                }
                Console.WriteLine("Количество квадратов: {0}", n);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Неверный формат введенного числа!");
                Console.ReadKey();
            }
        }
    }
}
