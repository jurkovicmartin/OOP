using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cv3
{
    public static class Run
    {
        static public void Main(String[] args)
        {
            double[,] first_data = new double[2, 2] { { 1, 5 }, { 3, 6 } };
            double[,] second_data = new double[2, 2] { { 6, 5 }, { 8, 6 } };

            Matrix first_matrix = new Matrix(first_data);
            Matrix second_matrix = new Matrix(second_data);

            Console.WriteLine("First matrix is:\n" + first_matrix);
            Console.WriteLine("Second matrix is:\n" + second_matrix);

            Console.WriteLine("Summary");
            Console.WriteLine(first_matrix + second_matrix);
            Console.WriteLine("Difference");
            Console.WriteLine(first_matrix - second_matrix);
            Console.WriteLine("Multiplication");
            Console.WriteLine(first_matrix * second_matrix);
            Console.WriteLine("Equals");
            Console.WriteLine(first_matrix == second_matrix);
            Console.WriteLine("\nUnary");
            Console.WriteLine(-first_matrix);

            Console.WriteLine("Determinant");
            Console.WriteLine(Matrix.Determinant(first_matrix));
        }
    }
}
