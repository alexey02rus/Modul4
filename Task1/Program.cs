using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 0");
            Console.Write("N = ");
            string value = Console.ReadLine();
            Console.WriteLine("");
            bool integer = Int32.TryParse(value, out int n);
            if (integer && n > 0)
            {
                int n2 = 0;
                for (int i = 1; i <= n; i++)
                {
                    n2 += 2 * i - 1;
                    Console.WriteLine("Квадрат числа {0} = {1}", i, n2);
                }
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
