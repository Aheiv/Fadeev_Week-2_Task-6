using System;

namespace ЛАБ6_2_УП
{
    class Program
    {
        static int[] Array()
        {
            int n;
            Console.Write("Введите число элементов массива: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Некорректный ввод данных!\nВведите число элементов массива: ");
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                    Console.Write("Некорректный ввод данных!\na[{0}]= ", i);
            }
            return a;
        }
        static void OutArray(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] > max) max = a[i];
            return max;
        }
        static void Main(string[] args)
        {
            int[] Mas = Array();
            OutArray(Mas);
            int index = 0;
            int max = Max(Mas);
            for (int i = 0; i < Mas.Length; i++)
            {
                if (max == Mas[i])
                {
                    index = i;
                    break;
                }
                else continue;
            }
            Console.WriteLine("Номер первого максимального элемента: " + index);
        }
    }
}
