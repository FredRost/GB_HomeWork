Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOfDigits = NumberOfDigits(number);
Console.WriteLine($"Количество цифр в числе {number} = {numberOfDigits}");


int NumberOfDigits (int num)
{
    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i ++;
    }
    return i;
}