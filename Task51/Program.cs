﻿int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];

Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(min, max + 1);
}

}
return matrix;
}

void PrintMatrix(int[,] matrix)
{

for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j],3}");
}
Console.WriteLine("|");
}

}


int SumElemOnDigonal(int[,] matrix)
{ int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i == j)
{
sum += matrix[i,j];
}
}
}
return sum;
}

int[,] array2d = CreatMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
Console.WriteLine();
int sumElemOnDigonal = SumElemOnDigonal(array2d);
Console.WriteLine($"{sumElemOnDigonal}");