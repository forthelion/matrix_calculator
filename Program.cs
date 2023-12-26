using System;
using System.Collections.Generic;

namespace matrix_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop until users quits program. The user quites the program by typing exit which turns The bool Exit value true stopping the loop. will give it more users tolerances 
            bool Exit = false;
            while (Exit == false)
            {
                Console.WriteLine("Do you want to add? type +");

                Console.WriteLine("Do you want to subtract? type -");

                Console.WriteLine("Do you want to Reduced Row Echelon Form? type RREF");

                Console.WriteLine("Do you want to do multiplication ? type *");

                Console.WriteLine("Do you want to quit program? type exit");
                string userInput = Console.ReadLine();
                Console.WriteLine("You entered: " + userInput);

                switch (userInput)
                {
                    case "*":
                        int[,] matrix1 = Functions.setupMatrix();
                        int[,] matrix2 = Functions.setupMatrix();
                        multiplication(matrix1, matrix2);
                        break;
                    case "+":
                        // fill out matrix 
                        int[,] matrix1add = Functions.setupMatrix();
                        int[,] matrix2add = Functions.setupMatrix();
                        Add(matrix1add, matrix2add);
                        break;

                    case "-":
                        int[,] matrix1minus = Functions.setupMatrix();
                        int[,] matrix2minus = Functions.setupMatrix();
                        minus(matrix1minus, matrix2minus);
                        break;

                    case "RREF":
                        RREF();
                        break;
                    case "exit":
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("can you type again?");
                        break;

                }

                
            }
        }

        private static void Add(int[,] matrix1, int[,] matrix2)
        {
            List<int> infoM1 = Functions.infoMatrix(matrix1);
            List<int> infoM2 = Functions.infoMatrix(matrix2);
            if(infoM1[0]==infoM2[0] && infoM1[1] == infoM2[1])
            {
                int[,] matrix = Functions.addMatrix(matrix1, matrix2, infoM1);
                Console.WriteLine("result of calculation");
                Functions.printMatrix(matrix);    
            }
            else
            {
                Console.WriteLine("please reenter as matrix cant be added together");
            }
           
        }

        

        private static void minus(int[,] matrix1, int[,] matrix2)
        {
            List<int> infoM1 = Functions.infoMatrix(matrix1);
            List<int> infoM2 = Functions.infoMatrix(matrix2);
            if (infoM1[0] == infoM2[0] && infoM1[1] == infoM2[1])
            {
                int[,] matrix = Functions.minusMatrix(matrix1, matrix2, infoM1);
                Console.WriteLine("result of calculation");
                Functions.printMatrix(matrix);
            }
            else
            {
                Console.WriteLine("please reenter as matrix cant be added together");
            }

        }

        private static void multiplication(int[,] matrix1, int[,] matrix2)
        {
            List<int> infoM1 = Functions.infoMatrix(matrix1);
            List<int> infoM2 = Functions.infoMatrix(matrix2);
            // matrix[ (row = [matrixinfo[0]), (column = [matrixinfo[1]))
            //https://www.khanacademy.org/math/precalculus/x9e81a4f98389efdf:matrices/x9e81a4f98389efdf:multiplying-matrices-by-matrices/v/multiplying-a-matrix-by-a-matrix#:~:text=Matrix%20multiplication%20is%20only%20valid,columns%20of%20the%20second%20matrix.
            if ((infoM1[0] == infoM2[1]))
            {
                int[,] matrix = Functions.multiplicationMatrix(matrix1, matrix2, infoM1,infoM2);
                Console.WriteLine("result of calculation");
                Functions.printMatrix(matrix);
            }
            else
            {
                Console.WriteLine("please reenter as matrix cant be added together");
            }
            
        }

        private static void RREF()
        {
            throw new NotImplementedException();
        }


    }

    





  

    
}
