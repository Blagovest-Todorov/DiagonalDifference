using System;
using System.Linq;

namespace ExerDiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqrMatrixSize = int.Parse(Console.ReadLine());

            //create the nSquare Matrix declare it
            int[,] matrix = new int[sqrMatrixSize, sqrMatrixSize];

            for (int row = 0; row < sqrMatrixSize; row++)  // fill the matrix
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < sqrMatrixSize; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int firstDiagonalSum = 0;
            int secDigonalSum = 0;

            for (int row = 0; row < sqrMatrixSize; row++)
            {
                for (int col = 0; col < sqrMatrixSize; col++)
                {
                    if (row == col)
                    {
                        firstDiagonalSum += matrix[row, col];
                    }
                }
            }

            int rowM = sqrMatrixSize - 1;

            for (int col = 0; col < sqrMatrixSize; col++)
            {                
                secDigonalSum += matrix[rowM, col];
                rowM -= 1;
            }

            int result = Math.Abs(firstDiagonalSum- secDigonalSum);
            Console.WriteLine(result);
        }
    }
}
