using System;

namespace MatricesCalculator
{
    class Program
    {
        private static void Main()
        {
            Console.Title = "Matrice Calculator";

            Console.WriteLine("Enter the number of the operation you want to use\n1) Addition\n2) Subtraction\n3) Multiplication\n4) Inverse\n5) Transpose\n");

            Main:

            switch (Console.ReadKey().Key)
            {
                // Addition
                case ConsoleKey.D1:
                    {
                        Console.Clear();
                        AddMatrix();
                        Console.ReadLine();
                        break;
                    }
                // Subtraction
                case ConsoleKey.D2:
                    {
                        Console.Clear();
                        SubtractMatrix();
                        Console.ReadLine();
                        break;
                    }
                // Mutliplication
                case ConsoleKey.D3:
                    {
                        Console.Clear();
                        MultiplyMatrix();
                        Console.ReadLine();
                        break;
                    }
                // Inverse
                case ConsoleKey.D4:
                    {
                        Console.Clear();
                        InverseMatrix();
                        Console.ReadLine();
                        break;
                    }
                // Transpose
                case ConsoleKey.D5:
                    {
                        Console.Clear();
                        TransposeMatrix();
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.Write("You didn't select a valid operation!\n\n");
                        goto Main;
                    }
            }
            Console.ReadLine();
        }

        private static void MultiplyMatrix()
        {
            // Define Variables

            int i;
            int j;

            Console.WriteLine("Enter the amount of rows in the matrix:\n");

            Rows:

            bool isNumericRows = Int32.TryParse(Console.ReadLine(), out int rows);

            if (isNumericRows)
            {
                Console.WriteLine("\nEnter the amount of columns in the matrix:\n");

                Columns:

                bool isNumericColumns = Int32.TryParse(Console.ReadLine(), out int columns);

                if (isNumericColumns)
                {
                    // Enter the values of the first matrix

                    Console.WriteLine("\nInput the values of the first matrix:\n");

                    int[,] firstMatrix = CreateMatrix(rows, columns);

                    // Enter the values of the second matrix

                    Console.WriteLine("\nInput the values of the second matrix:\n");

                    int[,] secondMatrix = CreateMatrix(rows, columns);

                    Console.Clear();

                    // Display first matrix to the user

                    Console.WriteLine("\nThe first matrix is:\n");

                    PrintMatrix(firstMatrix);

                    // Display second matrix to the user

                    Console.WriteLine("\nThe second matrix is:\n");

                    PrintMatrix(secondMatrix);

                    int[,] result = new int[rows, columns];

                    // Calculate the product of the two matrixs

                    for (i = 0; i < rows; i++)
                    {
                        for (j = 0; j < columns; j++)
                        {
                            result[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
                        }
                    }

                    // Display the product of the two matrixs

                    Console.WriteLine("\nThe result of the calculation is:\n");

                    PrintMatrix(result);

                    Console.WriteLine("\nPress enter to return to the main menu...");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Main();
                    }

                    Console.Read();
                }
                else
                {
                    Console.Write("You didn't enter a valid numeric value for the amount of columns!\n");
                    goto Columns;
                }
            }
            else
            {
                Console.Write("You didn't enter a valid numeric value for the amount of rows!\n");
                goto Rows;
            }
        }

        private static void AddMatrix()
        {
            // Define Variables

            int i;
            int j;

            Console.WriteLine("Enter the amount of rows in the matrix:\n");

            Rows:

            bool isNumericRows = Int32.TryParse(Console.ReadLine(), out int rows);

            if (isNumericRows)
            {
                Console.WriteLine("\nEnter the amount of columns in the matrix:\n");

                Columns:

                bool isNumericColumns = Int32.TryParse(Console.ReadLine(), out int columns);

                if (isNumericColumns)
                {
                    // Enter the values of the first matrix

                    Console.WriteLine("\nInput the values of the first matrix:\n");

                    int[,] firstMatrix = CreateMatrix(rows, columns);

                    Console.WriteLine("\nInput the values of the second matrix:\n");

                    // Enter the values of the second matrix

                    int[,] secondMatrix = CreateMatrix(rows, columns);

                    Console.Clear();

                    // Display first matrix to the user

                    Console.WriteLine("\nThe first matrix is:\n");

                    PrintMatrix(firstMatrix);

                    // Display second matrix to the user
                    Console.WriteLine("\nThe second matrix is:\n");

                    PrintMatrix(secondMatrix);

                    int[,] result = new int[rows, columns];

                    // Calculate the sum of the two matrixs

                    for (i = 0; i < rows; i++)
                    {
                        for (j = 0; j < columns; j++)
                        {
                            result[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                        }
                    }

                    // Display the sum of the two matrixs

                    Console.WriteLine("\nThe result of the sum is:\n");

                    PrintMatrix(result);

                    Console.WriteLine("\nPress enter to return to the main menu...");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Main();
                    }

                    Console.Read();
                }
                else
                {
                    Console.Write("You didn't enter a valid numeric value for the amount of columns!\n");
                    goto Columns;
                }
            }
            else
            {
                Console.Write("You didn't enter a valid numeric value for the amount of rows!\n");
                goto Rows;
            }
        }

        private static void SubtractMatrix()
        {
            // Define Variables

            int i;
            int j;

            Console.WriteLine("Enter the amount of rows in the matrix:\n");

            Rows:

            bool isNumericRows = Int32.TryParse(Console.ReadLine(), out int rows);

            if (isNumericRows)
            {
                Console.WriteLine("\nEnter the amount of columns in the matrix:\n");

                Columns:

                bool isNumericColumns = Int32.TryParse(Console.ReadLine(), out int columns);

                if (isNumericColumns)
                {
                    // Enter the values of the first matrix

                    Console.WriteLine("\nInput the values of the first matrix:\n");

                    int[,] firstMatrix = CreateMatrix(rows, columns);

                    // Enter the values of the second matrix

                    Console.WriteLine("\nInput the values of the second matrix:\n");

                    int[,] secondMatrix = CreateMatrix(rows, columns);

                    Console.Clear();

                    // Display first matrix to the user

                    Console.WriteLine("\nThe first matrix is:\n");

                    PrintMatrix(firstMatrix);

                    // Display second matrix to the user

                    Console.WriteLine("\nThe second matrix is:\n");

                    PrintMatrix(secondMatrix);

                    int[,] result = new int[rows, columns];

                    // Calculate the sum of the two matrixs

                    for (i = 0; i < rows; i++)
                    {
                        for (j = 0; j < columns; j++)
                        {
                            result[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                        }
                    }

                    // Display the sum of the two matrixs

                    Console.WriteLine("\nThe result of the sum is:\n");

                    PrintMatrix(result);

                    Console.WriteLine("\nPress enter to return to the main menu...");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Main();
                    }

                    Console.Read();
                }
                else
                {
                    Console.Write("You didn't enter a valid numeric value for the amount of columns!\n");
                    goto Columns;
                }
            }
            else
            {
                Console.Write("You didn't enter a valid numeric value for the amount of rows!\n");
                goto Rows;
            }
        }

        private static void TransposeMatrix()
        {
            // Define Variables

            int i;
            int j;

            Console.WriteLine("Enter the amount of rows in the matrix:\n");

            Rows:

            bool isNumericRows = Int32.TryParse(Console.ReadLine(), out int rows);

            if (isNumericRows)
            {
                Console.WriteLine("\nEnter the amount of columns in the matrix:\n");

                Columns:

                bool isNumericColumns = Int32.TryParse(Console.ReadLine(), out int columns);

                if (isNumericColumns)
                {
                    // Enter the values of the matrix

                    Console.WriteLine("\nInput the values of the matrix:\n");

                    int[,] matrix = CreateMatrix(rows, columns);

                    Console.Clear();

                    // Display the matrix to the user

                    Console.WriteLine("\nThe matrix is:\n");

                    PrintMatrix(matrix);

                    int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];

                    // Calculate the transpose of the matrix

                    for (i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (j = 0; j < matrix.GetLength(1); j++)
                        {
                            result[j, i] = matrix[i, j];
                        }
                    }

                    // Display the result of the transpose to user

                    Console.WriteLine("\nThe transpose of the matrix is:\n");

                    PrintMatrix(result);

                    Console.WriteLine("\nPress enter to return to the main menu...");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Main();
                    }

                    Console.Read();
                }
                else
                {
                    Console.Write("You didn't enter a valid numeric value for the amount of columns!\n");
                    goto Columns;
                }
            }
            else
            {
                Console.Write("You didn't enter a valid numeric value for the amount of rows!\n");
                goto Rows;
            }
        }

        private static void InverseMatrix()
        {
            // Define Variables

            int i;
            int j;

            Console.WriteLine("Enter the amount of rows in the matrix:\n");

            Rows:

            bool isNumericRows = Int32.TryParse(Console.ReadLine(), out int rows);

            if (isNumericRows)
            {
                Console.WriteLine("\nEnter the amount of columns in the matrix:\n");

                Columns:

                bool isNumericColumns = Int32.TryParse(Console.ReadLine(), out int columns);

                if (isNumericColumns)
                {
                    // Enter the values of the matrix

                    Console.WriteLine("\nInput the values of the matrix:\n");

                    int[,] matrix = CreateMatrix(rows, columns);

                    Console.Clear();

                    // Display the matrix to the user

                    Console.WriteLine("\nThe matrix is:\n");

                    PrintMatrix(matrix);

                    // Calculate the inverse of the matrix

                    var topLeft = matrix[0, 0];
                    var topRight = matrix[1, 0];
                    var bottomLeft = matrix[0, 1];
                    var bottomRight = matrix[1, 1];

                    var productOne = topLeft * bottomRight;

                    var productTwo = topRight * bottomLeft;

                    var finalSum = productOne - productTwo;

                    var determinant = Decimal.Divide(1, finalSum);

                    decimal[,] inverse = new decimal[rows, columns];

                    for (i = 0; i < rows; i++)
                    {
                        for (j = 0; j < columns; j++)
                        {
                            var value = matrix[i, j] * determinant;

                            inverse[i, j] = value;
                        }
                    }

                    // Display the inverse of the matrix to the user

                    Console.WriteLine("\nThe inverse of the matrix is:\n");

                    for (i = 0; i < rows; i++)
                    {
                        for (j = 0; j < columns; j++)
                        {
                            Console.Write(inverse[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nPress enter to return to the main menu...");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Main();
                    }

                    Console.Read();
                }
                else
                {
                    Console.Write("You didn't enter a valid numeric value for the amount of columns!\n");
                    goto Columns;
                }
            }
            else
            {
                Console.Write("You didn't enter a valid numeric value for the amount of rows!\n");
                goto Rows;
            }
        }

        private static int[,] CreateMatrix(int rows, int columns)
        {
            // Get the values of the matrix

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Start:
                    var isNumber = Int32.TryParse(Console.ReadLine(), out int value);

                    if (isNumber)
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        Console.Write("You didn't enter a valid numeric value!\n");
                        goto Start;
                    }
                }
            }
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}