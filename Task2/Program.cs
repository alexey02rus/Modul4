using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int n = 0;
            do
            {
                Console.WriteLine("Введите целое положительное или отрицательное число. 0 - для окончания");
                string value = Console.ReadLine();
                bool integer = Int32.TryParse(value, out n);
                if (integer)
                {
                    if (n>0)
                    {
                        i++;
                    }
                    else if (n<0)
                    {
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный формат введенного числа!");
                    n = 1;
                }
            } while (n != 0);
            Console.WriteLine();
            Console.WriteLine($"Количество положительных чисел: {i}");
            Console.WriteLine($"Количество отрицательных чисел: {j}");
            Console.ReadKey();

        }
    }
}
