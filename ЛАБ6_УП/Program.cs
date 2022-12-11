using System;

namespace ЛАБ6_1_УП
{
    class Program
    {
        static int [] Array ()
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

        static void NineMas (int [] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (Math.Abs(a[i]) % 9 == 0 && a[i] != 0)
                {
                    sum += a[i];
                }
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int[] Mas = Array();
            Console.Write("Исходный массив: ");
            OutArray(Mas);
            Console.Write("Сумма элементов, кратных 9: ");
            NineMas(Mas);
        }
    }
}
