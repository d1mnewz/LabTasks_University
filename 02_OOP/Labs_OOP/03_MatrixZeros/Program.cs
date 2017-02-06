using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MatrixZeros
{
//    Задано квадратну матрицю, всі елементи якої рівні одиниці.Написати
//    функцію void func(int** arr, int n), котра заповняє заштриховану область
//    матриці(згідно варіанту) нулями.Розмір масиву вводиться з клавіатури.
//    reverse diagonal top
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n]; // 2d array
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = 0;
                }
            }
            func(ref arr, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Convert.ToInt16(arr[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void func(ref int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    arr[i, j] = 1;
                }
            }
        }
    }
}
