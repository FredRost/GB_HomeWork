int rowMatrix = Input("Введите кол-во строк в массиве m: ");
int colMatrix = Input("Введите кол-во столбцов в массиве n: ");

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, 1, 10);
PrintMatrix(matrixNew);
int[] arr1 = MatrixToArray(matrixNew);
PrintArray(arr1);
Dictionary(arr1);
void Dictionary(int[] arr)
{
int count = 1;
int value = arr[0];
Array.Sort(arr); // сортирует от мин до макс

for (int i = 1; i < arr.Length; i++)
{
if (value == arr[i]) count++;
else
{
Console.WriteLine($"{value} ---> {count}");
value = arr[i];
count = 1;
}
}
Console.WriteLine($"{value} ---> {count}");
}

int[] MatrixToArray(int[,] matrix)
{
int[] array = new int[matrix.Length];
int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
array[count++] = matrix[i, j];
// count += 1;
}
}
return array;
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

int Input(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
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

void PrintArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
Console.WriteLine("]");
}