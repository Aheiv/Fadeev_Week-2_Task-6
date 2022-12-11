using System;

namespace ЛАБ6_3_УП
{
    class Program
    {
        static int[,] Array(out int n, out int k)
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
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
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

        static void Change(int [,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j += 2)
                {
                    int temp = a[i, j];
                    a[i, j] = a[i, j + 1];
                    a[i, j + 1] = temp;
                }
            }  
        }
        static void Main(string[] args)
        {
            int n, k;
            int[,] Mas = Array(out n, out k);
            Console.WriteLine("Исходный массив:");
            Print(Mas);
            if (k % 2 == 0)
            {
                Console.WriteLine("Изменённый массив");
                Change(Mas);
                Print(Mas);
            }
            else Console.WriteLine ("Нечётное кол-во столбцов, изменения не будут проведены");
        }
    }
}
