int InputInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

double[,] GenerateArray(int row, int col)
{
    double[,] array = new double[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2} ");
        }
    }
    System.Console.WriteLine();
}

int row = InputInt("Введите количество строк");
int col = InputInt("Введите колиество столбцов");

double[,] matrix = GenerateArray(row, col);
PrintArray(matrix);