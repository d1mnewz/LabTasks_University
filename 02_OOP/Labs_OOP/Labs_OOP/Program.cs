using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_OOP
{
    //    Написати реалізацію перевантажених функцій:
    //    int func(double* arr, int length);
    //    int func(char* str);
    //    Функція func повертає кількість елементів, які більші за своїх сусідів.
    class Program
    {

        const string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
        

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int length = rnd.Next(5, 15);
            double[] arr = new double[length];
            char[] str = new char[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = (double)rnd.Next(-100, 100) + (double)rnd.Next(100) / 100;
                str[i] = chars[rnd.Next(0, chars.Length - 1)];
            }
            foreach (var el in arr)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {func(arr, length)} elements that are bigger than their neighbours.");
            Console.WriteLine();
            Console.WriteLine(str);
            Console.WriteLine($"There are {func(str)} elements that are bigger than their neighbours.");
            Console.WriteLine("Using ASCII Table to compare. ");
            Console.WriteLine();


        }
        public static int func(double[] arr, int length)
        {
            if (arr.Length == 0)
                return 0;
            else if (arr.Length != length)
                throw new ArgumentException("Length isn`t correct.");
            else
            {
                int counter = 0;
                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            counter++;
                        }

                    }
                    else if (i == length - 1)
                    {
                        if (arr[i] > arr[i - 1])
                        {
                            counter++;

                        }
                    }
                    else if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                        counter++;
                }
                return counter;
            }
        }
        public static int func(char[] str)
        {
            //string str = str.ToString();
            if (str.Length == 0)
               return 0;
            else
            {
                int length = str.Length;
                int counter = 0;
                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        if ((int)str[i] > (int)str[i + 1])
                        {
                            counter++;
                        }

                    }
                    else if (i == length - 1)
                    {
                        if ((int)str[i] > (int)str[i - 1])
                        {
                            counter++;

                        }
                    }
                    else if (str[i] > (int)str[i - 1] && (int)str[i] > (int)str[i + 1])
                        counter++;
                }
                return counter;
            }

        }
    }
}
