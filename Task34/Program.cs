﻿int[] GenerateArray()
{
    int[] array = new int[5];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int ValidateEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int [] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве {ValidateEven(array)}");