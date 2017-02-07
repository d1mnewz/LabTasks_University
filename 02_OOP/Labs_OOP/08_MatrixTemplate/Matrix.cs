using _08_MatrixTemplate;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MatrixTemplate
{
    public class Matrix<T>
    where T : struct,
     IComparable<T>,
     IConvertible,
     IEquatable<T>,
     IFormattable
    {
        readonly T[,] matr;
        public int rows;

        public int Rows
        {
            get { return rows; }
        }

        public int Cols
        {
            get { return cols; }
        }

        public int cols;

        public Matrix(T[,] table)
        {
            matr = table;
            rows = matr.GetLength(0);//problem here
            cols = matr.GetLength(1);//problem here
        }

        public void PrintMatrix()
        {

            for (int i = 0; i < rows; i++)
            {
                //Matr

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"\t{matr[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        
        public void GetRowIdxWithMaxSum()
        {
            int maxIdx = 0;
            T sum;
            T largestSum = default(T);
            for (int i = 0; i < rows; i++)
            {
                //Matr
                sum = default(T);
                for (int j = 0; j < cols; j++)
                {
                    sum = (dynamic)matr[i,j] + sum;
                    //Console.WriteLine(sum);
                }
                if ((dynamic)sum > largestSum)
                {
                    largestSum = sum;
                    maxIdx = i;
                }
                
            }
            Console.WriteLine($"max index = {maxIdx}, max sum = {largestSum}");
            //return maxIdx;
        }

    }
}
