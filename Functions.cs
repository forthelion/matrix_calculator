using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace matrix_calculator
{
    class Functions
    {
        //number checkers 
        //   function should loop until user enters a valied number and return if user exits before it negavitve -1 marking for error 
        // need to refactor
        public static int IsItNumber()
        {
            int userNumber = 0;
            bool exit = false;
            while (!exit)
            {
                string userInput = Console.ReadLine();
                //bool NumberTrue = int.TryParse(userInput, out a);
                bool NumberTrue = int.TryParse(userInput, out int a);
                if (NumberTrue)
                {
                    userNumber = int.Parse(userInput);
                    return userNumber;
                }
            }
            // should never reach here
            return -1;
        }
        // ask users for row and then column
        public static int[,] setupMatrix()
        {
            Console.WriteLine("enter number of row");
            int row = IsItNumber();
            Console.WriteLine("enter number of columns");
            int column = IsItNumber();
            int[,] matrix;

            matrix = new int[row, column];

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.WriteLine("enter number");
                    matrix[i, j] = Convert.ToInt16(IsItNumber());
                    printMatrix(matrix);// System.IndexOutOfRangeException: 'Index was outside the bounds of the array
                }
                printMatrix(matrix);
            }
            return matrix;
        }
        // add a exception here if there nothing so it will be zero 
        public static void printMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        public static List<int> infoMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            int columns = matrix.GetLength(1);

            List<int> info = new List<int>();
            info.Add(rows);
            info.Add(columns);
            return info;

        }
        public static int[,] addMatrix(int[,] matrix1, int[,] matrix2,List<int> matrixinfo)
        {
            int[,] matrix;
            // matrix[ (row = [matrixinfo[1]), (column = [matrixinfo[2]))
            matrix = new int[matrixinfo[0], matrixinfo[1]];

            for (int i = 0; i < matrixinfo[1]; i++)
            {
                for (int j = 0; j < matrixinfo[0]; j++)
                {
                    matrix[i, j] = matrix1[i,j]+matrix2[i,j];
                    
                }
            }

            return matrix;

        }
        public static int[,] minusMatrix(int[,] matrix1, int[,] matrix2, List<int> matrixinfo)
        {
            int[,] matrix;
            // matrix[ (row = [matrixinfo[1]), (column = [matrixinfo[2]))
            matrix = new int[matrixinfo[0], matrixinfo[1]];

            for (int i = 0; i < matrixinfo[1]; i++)
            {
                for (int j = 0; j < matrixinfo[0]; j++)
                {
                    matrix[i, j] = matrix1[i, j] - matrix2[i, j];

                }
            }

            return matrix;

        }

        public static int[,] multiplicationMatrix(int[,] matrix1, int[,] matrix2, List<int> matrixinfo1, List<int> matrixinfo2)
        {
            int[,] matrix;
            // matrix[ (row = [matrixinfo[1]), (column = [matrixinfo[2]))
            matrix = new int[matrixinfo1[0], matrixinfo1[1]];

            for (int i = 0; i < matrixinfo1[1]; i++)
            {
                for (int j = 0; j < matrixinfo1[0]; j++)
                {
                    matrix[i, j] = matrix1[i, j] - matrix2[i, j];

                }
            }

            return matrix;

        }





    }
}
