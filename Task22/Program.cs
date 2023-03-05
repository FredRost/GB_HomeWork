Console.WriteLine("Введите положительное натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    TableSquare(number);
}

else
{
    Console.WriteLine("Число не положительное");
}

void TableSquare (int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i, 4} -> {i*i, 4}");
        i++;
    }
}
