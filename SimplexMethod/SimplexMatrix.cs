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
        private double[] _target; // function like z = c0 + c1x1 + c2x2 ... just put here the c0, c1 and etc.
        private int basisCount;
        private int freeCount;

        public SimplexMatrix(double[,] matrix, double[] target)
        {
            _dataMatrix = matrix;
            _target = target;
        }

        public void ProcessMatrix(int freeCount, int basisCount)
        {
            this.basisCount = basisCount;
            this.freeCount = freeCount;
            OptimizeMatrix();
            CreateSimplex();

            int target = freeCount;
            if (NeedFiction())
            {
                target = freeCount + 1;
            }

            int k = 0;
            while(!checkBFS(target) && k < 100)
            {
                RowImprove(target);
                k++;
            }
        }    

        private void OptimizeMatrix()
        {
            for(int i = 0; i < _dataMatrix.GetUpperBound(0); i++)
            {                
                for (int j = 0; j < _dataMatrix.GetUpperBound(1); j++)
                {
                    double frac = Math.Abs(_dataMatrix[i, j] - Math.Truncate(_dataMatrix[i, j]));
                    
                    if (frac > 0)
                    {
                        MathExtend.MultipleMatrixRow(ref _dataMatrix, 1 / frac, i);
                    }
                }
            }
        }

        private void CreateSimplex() // first simplex table filling
        {
            _matrix = new double[freeCount + 2, basisCount + freeCount + 2];

            for(int i = 0; i < freeCount; i++) // first column besides c0
            {
                _matrix[i, 0] = _dataMatrix[i, basisCount + freeCount];
            }

            for (int i = 0; i <= freeCount; i++) // z row besides basis variables
            {
                _matrix[freeCount, i] = - _target[i];
            }

            for (int i = freeCount + 1; i < basisCount + freeCount; i++) // z row, basis variables
            {
                _matrix[basisCount, i] = 0;
            }

            for (int i = 0; i < basisCount; i++) // a11, a12 and etc
            {
                for (int j = 1; j < basisCount + freeCount + 1; j++)
                {
                    _matrix[i, j] = _dataMatrix[i, j - 1];
                }
            }

            for (int i = 0; i < basisCount + 2; i++) // sum rows
            {
                double sum = 0;
                for (int j = 0; j < basisCount + freeCount + 1; j++) 
                {
                    sum += _matrix[i, j];
                }
                _matrix[i, basisCount + freeCount + 1] = sum;
            }
        }

        private bool NeedFiction()
        {
            bool res = false;
            for (int i = 0; i < freeCount; i++) // first column besides c0
            {
                if(_matrix[i, 0] < 0)
                {
                    res = true;
                    MathExtend.SumMatrixRows(ref _matrix, i, freeCount + 1);
                }
            }
            return res;
        }

        private bool checkBFS(int targetRow)
        {
            bool res = true;
            for (int i = 1; i < basisCount + freeCount + 1; i++) // besides c0
            {
                if (_matrix[targetRow, i] < 0)
                {
                    res = false;                    
                }
            }
            return res;
        }

        private void RowImprove(int target)
        {
            int col = SolvingColumn(target);
            int row = SolvingRow(col);
        }

        private int SolvingColumn(int target) // search for solving column
        {
            double absMax = 0;
            int absMaxIndex = 0;
            for (int i = 1; i < basisCount + freeCount + 1; i++)
            {
                if (_matrix[target, i] < 0)
                {
                    if (Math.Abs(_matrix[target, i]) > absMax)
                    {
                        absMax = -_matrix[target, i];
                        absMaxIndex = i;
                    }
                }
            }
            return absMaxIndex;
        }

        private int SolvingRow(int solvingColumn) // search for solving row
        {
            double minPositive = -1;
            int minPositiveIndex = 0;
            for (int i = 0; i < freeCount; i++)
            {
                if (_matrix[i, solvingColumn] == 0) continue;
                double frac = _matrix[i, 0] / _matrix[i, solvingColumn];
                if (frac >= 0)
                {
                    if (frac < minPositive || minPositive == -1)
                    {
                        minPositive = frac;
                        minPositiveIndex = i;
                    }
                }
            }

            if (minPositive == -1)
                throw new FormatException("При заданной системе ограничений функция z неограничена, т.е. поставленная задача линейного программирования решений не имеет");

            return minPositiveIndex;
        }
    }
}
