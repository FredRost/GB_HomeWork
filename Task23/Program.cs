Console.WriteLine("Введите положительное натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    TableQube(number);
}

else
{
    Console.WriteLine("Число не положительное");
}

void TableQube (int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i, 4} -> {i*i*i, 4}");
        i++;
    }
}