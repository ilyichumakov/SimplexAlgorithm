using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexMethod
{
    public class SimplexMatrix
    {
        private double[,] _matrix;
        private double[,] _dataMatrix;

        public SimplexMatrix(int basisCount, int freeCount)
        {
            _matrix = new double[freeCount + 2, basisCount + freeCount + 2];
        }

        public SimplexMatrix(double[,] matrix)
        {
            _dataMatrix = matrix;
        }

        public void ProcessMatrix()
        {
            OptimizeMatrix();
        }

        private void MultipleRow(double k, int rowNum)
        {
            for (int i = 0; i <= _dataMatrix.GetUpperBound(1); i++)
            {
                _dataMatrix[rowNum, i] = _dataMatrix[rowNum, i] * k;
            }
        }

        private void OptimizeMatrix()
        {
            for(int i = 0; i < _dataMatrix.GetUpperBound(0); i++)
            {
                double mostUgly = 0.0;
                double k = 1.0;
                for (int j = 0; j < _dataMatrix.GetUpperBound(1); j++)
                {
                    double frac = Math.Abs(_dataMatrix[i, j] - Math.Truncate(_dataMatrix[i, j]));
                    
                    if (frac > 0)
                    {
                        //if (mostUgly == 0.0)
                        //{
                        //    mostUgly = _dataMatrix[i, j];
                        //}
                        //else
                        //{
                        //    k = MathExtend.Nok(mostUgly, _dataMatrix[i, j]) / _dataMatrix[i, j];
                        //    MultipleRow(k, i);
                        //}
                        MultipleRow(1/frac, i);
                    }
                }
            }
        }
    }
}
