﻿int[] array = new int [8];
Random rand = new Random();

Array(array);
WriteArray(array);

void Array(int[] arr)
{
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 2);
}
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}