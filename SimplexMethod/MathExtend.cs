using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexMethod
{
    public class MathExtend
    {
        public static double Nod(double a, double b)
        {
            if (b < 0)
                b = -b;
            if (a < 0)
                a = -a;
            while (b > 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static double Nok(double a, double b)
        {
            return Math.Abs(a * b) / MathExtend.Nod(a, b);
        }

        public static void MultipleMatrixRow(ref double[,] matrix, double k, int rowNum)
        {
            for (int i = 0; i <= matrix.GetUpperBound(1); i++)
            {
                matrix[rowNum, i] = matrix[rowNum, i] * k;
            }
            
        }

        public static void SumMatrixRows(ref double[,] matrix, int resourseRow, int targetRow)
        {
            for (int i = 0; i <= matrix.GetUpperBound(1); i++)
            {
                matrix[targetRow, i] += matrix[resourseRow, i];
            }
        }

        public static void Jordan(ref double[,] matrix, int resourseRow, int resourseColumn)
        {
            
        }
    }
}
