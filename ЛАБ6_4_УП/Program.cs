using System;

namespace ЛАБ6_4_УП
{
    class Program
    {
        static int[][] Array()
        {
            int n;
            Console.WriteLine("Введите размерность массива");
            Console.Write("n = ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Некорректный ввод данных!\nn = ");
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    while (!int.TryParse(Console.ReadLine(), out a[i][j]))
                        Console.Write("Некорретный ввод данных!\na[{0},{1}]= ", i, j);
                }
            }
            return a;
        }
        static void OutArray1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == 0) Console.Write("(Положительных чисел нет в столбце №{0})\t\t", i);
                else Console.Write("{0}\t ", a[i]);
            }
        }

        static int GetPosNums(int[][] a, int[] b)
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i][j] > 0)
                    {
                        b[j] = a[i][j];
                        break;
                    }
                    else if (a[i][j] < 0)
                    {
                        b[j] = 0;
                    }
                }
            }
            return b[a.Length - 1];
        }

        static void OutArray2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,4} ", a[i] [j]);
        }

        static void Main(string[] args)
        {
            int[][] Mas = Array();
            Console.WriteLine("Исходный массив:");
            OutArray2(Mas);
            int[] NewMas = new int[Mas.Length];
            for (int i = 0; i < Mas.Length; ++i)
                NewMas[i] = GetPosNums(Mas, NewMas);
            Console.WriteLine("Новый массив:");
            OutArray1(NewMas);
        }
    }
}
