using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N > 0: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int s = 0;
        if (N <= 0)
        {
            Console.Write("Ошибка : число должно быть > 0");
        }
       else
        
        for (int i = 1; i <= N; i++)
        {
            s+= 2 * i - 1;
            Console.WriteLine($"Число {i}, его квадрат: {s}");
        }
        Console.ReadKey();
    }
}