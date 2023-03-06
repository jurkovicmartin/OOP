using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cv3
{
    public class Matrix
    {
        public double[,] Data { get; private set; }
        public int Rows => Data.GetLength(0);
        public int Colums => Data.GetLength(1);
        public Matrix(double[,] matrix)
        {
            Data = matrix;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Colums != b.Colums)
                throw new ArgumentException("Error matrix size, they must be the same size");

            var output = new double[a.Rows, a.Colums];
            
            for(int row = 0; row < a.Rows; row++)
            {
                for(int col = 0; col < a.Colums; col++)
                {
                    output[row, col] = a.Data[row, col] + b.Data[row,col];
                }
            }
            return new Matrix(output);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Colums != b.Colums)
                throw new ArgumentException("Error matrix size, they must be the same size");

            var output = new double[a.Rows, a.Colums];

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Colums; col++)
                {
                    output[row, col] = a.Data[row, col] - b.Data[row, col];
                }
            }
            return new Matrix(output);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Colums != b.Rows)
                throw new ArgumentException("Error matrix size");

            var output = new double[a.Rows, b.Rows];

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Colums; j++)
                {
                    output[i, j] = 0;
                    for (int k = 0; k < a.Colums; k++)
                    {
                        output[i, j] += a.Data[i, k] * b.Data[k, j];
                    }
                }
            }
            return new Matrix(output);
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Colums != b.Colums)
                throw new ArgumentException("Error matrix size, they must be the same size");

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Colums; col++)
                {
                    if (a.Data[row, col] != b.Data[row, col])
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public static Matrix operator -(Matrix a)
        {
            var output = new double[a.Rows, a.Colums];

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Colums; col++)
                {
                    output[row, col] = -a.Data[row, col];
                }
            }
            return new Matrix(output);
        }

        public override string ToString()
        {
           string output = "";

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Colums; col++)
                {
                    output += $"{Data[row, col]} ";   
                }
                output += Environment.NewLine;
            }
           return output;
        }

        public static double Determinant(Matrix a)
        {

            if (a.Rows != a.Colums)
                throw new ArgumentException("Error matrix size, matrix must be square");
            else if (a.Rows == 1)
            {
               return (a.Data[0, 0]);
            }
            else if(a.Rows == 2)
            {
                return (a.Data[0, 0] * a.Data[1, 1] - a.Data[0, 1] * a.Data[1, 0]);
            }
            else if(a.Rows == 3)
            {
                //a11a22a33 + a12a23a31 + a13a21a32 − a13a22a31 − a11a23a32 − a12a21a33
                return (a.Data[0, 0] * a.Data[1, 1] * a.Data[2, 2] + a.Data[0, 1] * a.Data[1, 2] * a.Data[2, 0] + a.Data[0, 2] * a.Data[1, 0] * a.Data[2, 1] 
                    - a.Data[0, 2] * a.Data[1, 1] * a.Data[2, 0] - a.Data[0, 0] * a.Data[1, 2] * a.Data[2, 1] - a.Data[0, 1] * a.Data[1, 0] * a.Data[2, 2]);
            }
 
                throw new ArgumentException("Error matrix size, matrix is bigger than 3x3");
        }

    }
}
