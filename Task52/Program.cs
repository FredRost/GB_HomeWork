﻿int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
    }
    System.Console.WriteLine();
}

void AvarageCol(int[,] array)
{
    double sum = 0;
    double avarage = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];

        }

        avarage = sum / array.GetLength(1);
        System.Console.WriteLine($"Среднее арифметическое элементов в столбце {j + 1} = {avarage:F1}");
        sum = 0;
    }
}

int[,] matrix = GenerateArray(4, 4);
PrintArray(matrix);
System.Console.WriteLine();
AvarageCol(matrix);