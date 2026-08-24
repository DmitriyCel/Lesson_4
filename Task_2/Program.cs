using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число > 0 ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Ошибка: число должно быть > 0");
            }
            else
                for (; n <= 10 ; n += 2 + (2 * n - 1))
                {
                    Console.WriteLine("Квадрат числа {0} равен {1}", n, n * n);
                }
            Console.ReadKey();
        }
    }
}
