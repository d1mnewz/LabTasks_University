using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IOfiles
{
//    З клавіатури вводиться прізвище, ім’я і розмір
//    депозиту, а у файл виводиться прізвище, ім’я і розмір
//    депозиту за 1, 3, 6 і 12 місяці з урахуванням ставки по
//    депозитам на рівні 4% на місяць
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int size = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText("result.txt",
                String.Format($"{name}\nDeposit amount - {size}\n1 month - {CountProfit(size, 1, 4)}\n3 month - {CountProfit(size, 3, 4)}\n6 month - {CountProfit(size, 6, 4)}\n12 month - {CountProfit(size, 12, 4)}"));
            //Console.WriteLine(CountProfit(size, 1, 4));
            //Console.WriteLine(CountProfit(size, 3, 4));
            //Console.WriteLine(CountProfit(size, 6, 4));
            //Console.WriteLine(CountProfit(size, 12, 4));
            //Console.WriteLine(CountProfit(size, 12, 4, true));
        }

        // bool adding 
        // by default your profit will transfer to your payment card. and you will get fixed rate for every month;
        // but if you add you profit from every month to your deposit, you will gain more money.
        public static double CountProfit(int depSize, int month, int percent, bool adding = false)
        {
            if (depSize <= 0)
                return 0;
            else if (!adding)
                return depSize + month * (depSize * percent / 100);
            else
            {
                for (int i = 0; i < month; i++)
                {
                    depSize += (depSize * percent / 100);
                }
                return depSize;
            }

        }
    }
}
