using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for dimensions of the first matrix
        Console.WriteLine("Enter the dimensions of the first matrix:");
        Console.Write("Rows: ");
        int rows1 = int.Parse(Console.ReadLine());
        Console.Write("Columns: ");
        int cols1 = int.Parse(Console.ReadLine());

        // Initialize the first matrix with user input
        int[,] matrix1 = new int[rows1, cols1];
        Console.WriteLine("Enter the values of the first matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                Console.Write("Element[{0},{1}]: ", i, j);
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Ask user for dimensions of the second matrix
        Console.WriteLine("Enter the dimensions of the second matrix:");
        Console.Write("Rows: ");
        int rows2 = int.Parse(Console.ReadLine());
        Console.Write("Columns: ");
        int cols2 = int.Parse(Console.ReadLine());

        // Initialize the second matrix with user input
        int[,] matrix2 = new int[rows2, cols2];
        Console.WriteLine("Enter the values of the second matrix:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write("Element[{0},{1}]: ", i, j);
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Multiply the two matrices and store the result in a new matrix
        if (cols1 != rows2)
        {
            Console.WriteLine("Error: Cannot multiply the two matrices.");
        }
        else
        {
            int[,] result = new int[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Display the resulting matrix
            Console.WriteLine("Result:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}