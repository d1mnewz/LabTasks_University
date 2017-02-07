using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MatrixTemplate
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Matrix<double> mr;
            double[,] arr = new double[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    arr[i, j] = Math.Round(rnd.NextDouble(), 2);
                }
            }
            mr = new Matrix<double>(arr);
            mr.PrintMatrix();
            mr.GetRowIdxWithMaxSum();

            Console.WriteLine();
            Matrix<int> mrInt;
            int[,] arrInt = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    arrInt[i, j] = rnd.Next(10);
                }
            }
            mrInt = new Matrix<int>(arrInt);
            mrInt.PrintMatrix();
            mrInt.GetRowIdxWithMaxSum();

        }
    }
}
