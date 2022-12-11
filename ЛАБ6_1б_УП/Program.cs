using System;

namespace ЛАБ6_1б_УП
{
    class Program
    {
        static int [,] Array(out int n, out int k)
        {
            Console.Write("Введите число строк массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Некорректный ввод данных!\nВведите число строк массива: ");
            Console.Write("Введите число столбцов массива: ");
            while (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
                Console.Write("Некорректный ввод данных!\nВведите число столбцов массива: ");
            int[,] a = new int[n, k];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < k; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    while (!int.TryParse(Console.ReadLine(), out a[i,j]))
                        Console.Write("Некорректный ввод данных!\na[{0},{1}]= ", i, j);
                }
            return a;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        static void NineMas (int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    if (Math.Abs(a[i,j]) % 9 == 0 && a[i,j] != 0)
                    {
                        sum += a[i,j];
                    }
                }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int n, k;
            int[,] Mas = Array(out n, out k);
            Console.WriteLine("Исходный массив:");
            Print(Mas);
            Console.Write("Сумма элементов, кратных 9: ");
            NineMas(Mas);
        }
    }
}
