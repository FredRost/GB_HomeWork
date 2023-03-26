int[,] matrix = CreateMatrixRndInt (4, 4, 1, 10);
PrintMatrix (matrix);
Console.WriteLine();
int[]minElemIndexes = MinElemIndexes (matrix);
int[,] newMatrix = DeleteMinRowColumn (matrix, minElemIndexes[0], minElemIndexes[1]);
PrintMatrix (newMatrix);


int[,] DeleteMinRowColumn (int[,] arr2D, int rowDel, int columnDel)
{
int[,] newArray2D = new int[arr2D.GetLength(0)-1,arr2D.GetLength(1)-1];
int m = 0, n = 0;
for (int i = 0; i < newArray2D.GetLength(0); i++)
{
if (m == rowDel) m++;
for (int j = 0; j < newArray2D.GetLength(1); j++)
{
if (n==columnDel) n++;
newArray2D[i, j] = arr2D[m, n];
n++;
}
n = 0;
m++;
}
return newArray2D;
}

int[] MinElemIndexes(int[,] arr2D)
{
int row = 0, column = 0;
for (int i = 0; i < arr2D.GetLength(0); i++)
{
for (int j = 0; j < arr2D.GetLength(1); j++)
{
if (arr2D[i, j] < arr2D[row, column])
{
row = i;
column = j;
}
}
}
return new int[]{row, column};
}

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
int[,] arr2D = new int[rows, columns];
Random rnd = new Random ();
for (int i = 0; i < arr2D.GetLength(0); i++)
{
for (int j = 0; j < arr2D.GetLength(1); j++)
{
arr2D[i,j] = rnd.Next(min, max+1);
}
}
return arr2D;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j],5}");
}
Console.WriteLine("|");
}
Console.WriteLine("");
}