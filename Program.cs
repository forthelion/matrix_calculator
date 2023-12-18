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
                if (userInput == "*")
                {
                    //ask for matrix 1 to be filled out
                    // ask for matrix 2 to be filled out 
                    multiplication();
                }
                if (userInput == "+")
                {
                    // fill out matrix 
                    int[,] matrix1 = Class1.setupMatrix();
                    int[,] matrix2 = Class1.setupMatrix();
                    Add(matrix1,matrix2);
                }

                if (userInput == "-")
                {
                    int[,] matrix1 = Class1.setupMatrix();
                    int[,] matrix2 = Class1.setupMatrix();
                    minus(matrix1,matrix2);
                }

                if (userInput == "RREF")
                {
                    // ask for matrix 1 to be filled out
                    RREF();
                }

                if (userInput == "exit")
                {
                    Exit = true;

                }
                else
                {
                    Console.WriteLine("can you type again?");
                }


                
            }
        }

        private static void Add(int[,] matrix1, int[,] matrix2)
        {
            List<int> infoM1 = Class1.infoMatrix(matrix1);
            List<int> infoM2 = Class1.infoMatrix(matrix2);
            if(infoM1[0]==infoM2[0] && infoM1[1] == infoM2[1])
            {
                int[,] matrix = Class1.addMatrix(matrix1, matrix2, infoM1);
                Console.WriteLine("result of calculation");
                Class1.printMatrix(matrix);    
            }
            else
            {
                Console.WriteLine("please reenter as matrix cant be added together");
            }
           
        }

        

        private static void minus(int[,] matrix1, int[,] matrix2)
        {
            List<int> infoM1 = Class1.infoMatrix(matrix1);
            List<int> infoM2 = Class1.infoMatrix(matrix2);
            if (infoM1[0] == infoM2[0] && infoM1[1] == infoM2[1])
            {
                int[,] matrix = Class1.minusMatrix(matrix1, matrix2, infoM1);
                Console.WriteLine("result of calculation");
                Class1.printMatrix(matrix);
            }
            else
            {
                Console.WriteLine("please reenter as matrix cant be added together");
            }

        }

        private static void multiplication()
        {
            throw new NotImplementedException();
        }

        private static void RREF()
        {
            throw new NotImplementedException();
        }


    }

    





  

    
}
