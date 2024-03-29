﻿namespace _3.MaximalSum
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] ints = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int rows = ints[0];
            int cols = ints[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
                {
                int[] indexes = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                    {
                    matrix[row, col] = indexes[col];
                    }
                }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < rows - 2; row++)
                {
                for (int col = 0; col < cols - 2; col++)
                    {
                    int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col];
                    currentSum += matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1];
                    currentSum += matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                        {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                        }
                    }
                }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRow; row < maxRow + 3; row++)
                {
                for (int col = maxCol; col < maxCol + 3; col++)
                    {
                    Console.Write(matrix[row, col] + "");
                    }
                Console.WriteLine();
                }
            }

        }
    }
